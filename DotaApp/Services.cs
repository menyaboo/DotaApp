using DotaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotaApp
{
    class Services
    {
        private readonly DBContext _context;

        public Services()
        {
            _context = new DBContext();
        }

        public async Task<List<Hero>> GetHeroes()
        {
            return await _context.Hero
            .Include(h => h.Attribute)
            .Include(h => h.TypeAttack)
            .ToListAsync();
        }

        public async Task<List<Update>> GetUpdates()
        {
            return await _context.Updates.ToListAsync();
        }

        public async Task<List<Skill>> GetSkillsByHero(int heroId)
        {
            return await _context.Skill
                .Where(s => s.hero_id == heroId)
                .ToListAsync();
        }

        public async Task UpdateHeroWithGroupItemsAndItems(Hero hero)
        {
            var heroItems = await _context.HeroItem
                .Where(hi => hi.hero_id == hero.id)
                .Include(hi => hi.Item)
                .Include(hi => hi.GroupItem)
                .ToListAsync();

            var groupItemsWithItems = heroItems
                .GroupBy(hi => hi.GroupItem.name)
                .Select(g => new GroupItemViewModel
                {
                    GroupName = g.Key,
                    ItemNames = g.Select(hi => hi.Item.image).ToList()
                })
                .ToList();

            hero.GroupItemsWithItems = groupItemsWithItems;
        }
    }
}

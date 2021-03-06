﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishAquariumWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FishAquariumWebApp.Pages.ItemParameters
{
    public class EditModel : PageModel
    {
        private readonly FishAquariumWebApp.Configurations.FishAquariumContext _context;

        public EditModel(FishAquariumWebApp.Configurations.FishAquariumContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ItemParameter ItemParameter { get; set; }
        public List<SelectListItem> Fishes { get; set; }
        public List<SelectListItem> Aquariums { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemParameter = await _context.ItemParameter.FirstOrDefaultAsync(m => m.Id == id);
            Fishes = (await _context.Fish.ToListAsync()).Select(x => new SelectListItem(x.Species.ToString(), x.Id.ToString())).ToList();
            Aquariums = (await _context.Aquarium.ToListAsync()).Select(x => new SelectListItem(x.Id.ToString(), x.Id.ToString())).ToList();
            Fishes.Insert(0, new SelectListItem("", ""));
            Aquariums.Insert(0, new SelectListItem("", ""));


            if (ItemParameter == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ItemParameter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParametersExists(ItemParameter.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ParametersExists(int id)
        {
            return _context.ItemParameter.Any(e => e.Id == id);
        }
    }
}

# ASPNET Core 2.0 Pages

## Step 1
- Uncomment the code in index.cshtml 
- Setup DI in Startup.cs
```   services.AddSingleton<TodoRepository>();```
- Inject the todorepo in the index.cshtml
```   @inject TodoRepository todoRepository```
- Add the postmethod (function) into the index.cshtml


``` @functions {
                [BindProperty]
                public TodoItem todoItem { get; set; }

                public async Task<IActionResult> OnPostAsync()
                {
                    if (ModelState.IsValid)
                    {
                        todoRepository.Save(todoItem);
                        return RedirectToPage();
                    }

                    return Page();
                }
            } 

```
## Step 2
- Play around!
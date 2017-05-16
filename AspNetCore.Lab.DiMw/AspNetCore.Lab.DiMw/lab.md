# Dependency injection and Middleware LAB

Simple REST MVC demo playing around with DI and Middleware

If on any point you get into trouble or can't explain the behavior: CALL OUT FOR HELP!

## Step one
- Open the solution
- Run it
- You should see: `["value1","value2"]`

## Step two add DI
- Remove `new CounterService(); //TODO: Replace new with DI` in values controller
- Setup Dependency Injection in startup.cs `.AddTransient<ICounterService, CounterService>();`
- Init the _counterService field in the constructor
- Runt it
- You should see: `["value1","value2"]`

## Step three add middleware
- In startup.cs add `.UseMiddleware<MiddleWareExample>();` to the app before `.UseMvc()`
- Review MiddleWareExample.cs
- Add breakpoint in Invoke method
- Debug it
- Confirm the breakpoint gets hit
- You should see: `["value1","value2"]`
- Why is that?

## Play around and see the differences
Here are some suggestions:
- Change the DI to .AddScoped
- Change the DI to .AddSingleton
- Move the MiddleWare to after `UserMvc`
- Add multiple UseMiddleware lines
- Move the DI in the middleware from the invoke method to the constructor
- Add breakpoints all over the place and play around
- Create a short circuiting middleware example




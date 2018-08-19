# Tech-Stack-Check
A sample project demonstrating various techniques and tech stack that will be used.

## Minimum Development Environment
* .Net Core 2.1 SDK ([download link](https://www.microsoft.com/net/download/dotnet-core/2.1) - Windows, Mac OS, and Linux)
* Recommended IDEs:
  * Visual Studio 2017 ([download link](https://visualstudio.microsoft.com/downloads/) - use free Community edition if you don't have an MSDN subscription)
  * Visual Studio Code ([download link](https://code.visualstudio.com/download))
* Recommended Git clients if you're not familiar with Git command-line and don't like the built-in ones to Visual Studio:
  * Atlassian SourceTree ([download link](https://www.sourcetreeapp.com/))
  * GitExtensions ([download link](https://github.com/gitextensions/gitextensions) - Windows only)
* Azure Storage Explorer ([download link](https://docs.microsoft.com/en-us/azure/vs-azure-tools-storage-manage-with-storage-explorer))

## Tech Stack
### Front-end
* ASP .Net Core
  * [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-2.1&tabs=visual-studio) - mainly to serve up a HTML page and use ViewBag contents where necessary
  * [SignalR](https://docs.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-2.1) - real-time web communication
  * [Bundler and Minifier](https://docs.microsoft.com/en-us/aspnet/core/client-side/bundling-and-minification?view=aspnetcore-2.1&tabs=visual-studio%2Caspnetcore2x) - combines and minimises static files
* HTML5, CSS, JavaScript
* CSS libraries included:
  * [Animate.css](https://daneden.github.io/animate.css/) - a lightweight CSS animation system
  * [Bootstrap 4](https://getbootstrap.com/docs/4.0/layout/grid/) - mainly for grid layout system
* JavaScript libraries included:
  * jQuery 3 Slim - mainly for Bootstrap 4 support. No AJAX or Effects - use a vanilla JS alternative below.
  * [Atomic.js](https://cferdinandi.github.io/atomic/) - a lightweight AJAX-with-promises library
  * [Placeholders.js](https://vanillajstoolkit.com/helpers/placeholders/) - a lightweight string-templating alternative to Moustache
  * [Animate.js](https://vanillajstoolkit.com/helpers/animate/) - a lightweight helper to trigger Animate.css animations
  * [Fittext.js](https://github.com/adactio/FitText.js) - easily make headlines fill up the width of its container, responsively. This is a port with no JQuery dependency.
 * [Jasmine](https://jasmine.github.io/) - JavaScript unit tests
 * [Chutzpah](http://mmanela.github.io/chutzpah/) - Unit test runner
  
### API layer
* ASP .Net Core Web API
* xUnit - unit test framework
* Moq - mocking framework

### Back-end/Data layer
* Azure Storage
  * Table storage for application records (NoSQL tables)
  * Table storage for configuration settings
  * Blob storage for images
* For Azure Storage emulation use either:
  * [Azure Storage Emulator](https://docs.microsoft.com/en-us/azure/storage/common/storage-use-emulator) on Windows - comes installed with Azure SDK
  * [Azurite](https://github.com/azure/azurite) on Windows, Mac OS, and Linux
  
 ## Instructions
 1. Clone this repository
 2. (Optional for testing Azure Storage connection) Emulate Azure Storage:
   1. Start emulation software with default settings
   2. Connect to it using Azure Storage Explorer to confirm emulation is running
   3. Add a new Table called 'Value'.
   4. Add a new row to Value table. Ensure the PartitionKey can be parsed as a valid integer.
   5. Modify appsettings.Development.json:
     * Set UseFakeTableStorage to false.
     * Update Table_StorageAccountConnectionString if necessary (it is using default Azure Storage Emulator path).
 3. Open a command prompt in the repository folder with the .sln file
 4. Run `dotnet build` to restore NuGet packages and build the solution.
 5. Run `dotnet test ./Tech-Stack-Check.Web.Tests/` and verify all tests pass.
 6. Run `dotnet run --project ./tech-stack-check.web/` to start Kestrel web server.
 7. Browse to website (usually [http://localhost:5000](http://localhost:5000)) and test functionality.
 8. `Ctrl-C` to exit the Kestrel web server in the command prompt.

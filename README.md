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
  * jQuery 3 - mainly for familiarity's sake. I would recommend vanilla JS where possible.
  * [Placeholders.js](https://vanillajstoolkit.com/helpers/placeholders/) - a lightweight string-templating alternative to Moustache
  * [Animate.js](https://vanillajstoolkit.com/helpers/animate/) - a lightweight helper to trigger Animate.css animations
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
  
 ## Instructions
 1. Clone this repository
 2. Start Azure Table Storage emulation
 3. Open a command prompt in the repository folder with the .sln file
 4. Run `dotnet build`
 5. `TODO steps to confirm test functionality is working`

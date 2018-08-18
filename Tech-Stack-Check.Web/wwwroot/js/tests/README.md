# README FOR JS UNIT TESTING      

## Prerequisites   
Ensure you have [Chutzpah Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=vs-publisher-2795.ChutzpahTestRunnerContextMenuExtension) installed.  
    
## Chutzpah.json    
In this case, you shouldn't require to modify the `chutzpah.json` file as it already includes all the references and tests.
      
## Adding a test
You can add a new js test file in the `www/js/tests` directory. Follow the same pattern that already exists.
      
## How to run the test   
Right click on a `.test.js` file in the `www/js/tests` directory and click on 'view in browser'. This will open an HTML page in your browser and show all tests there.
Even if you're tests are split into multiple files, with the current configuration, it should still show all your tests in that HTML page. If it doesn't, you may need to 
right-click on each `.test.js file`.   
      
Please note: tests may not run in IE, open in Chrome for best results.


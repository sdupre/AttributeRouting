﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Areas")]
    public partial class RouteAreasFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteAreas.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Areas", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes")]
        public virtual void GeneratingAreaRoutes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 7
 testRunner.When("I fetch the routes for the Areas controller\'s Index action");
#line 8
 testRunner.Then("the route url is \"Area/Index\"");
#line 9
  testRunner.And("the data token for \"area\" is \"Area\"");
#line 10
 testRunner.When("I fetch the routes for the HttpAreas controller\'s Get action");
#line 11
 testRunner.Then("the route url is \"ApiArea/Get\"");
#line 12
  testRunner.And("the data token for \"area\" is \"ApiArea\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes when route urls specify a duplicate area prefix")]
        public virtual void GeneratingAreaRoutesWhenRouteUrlsSpecifyADuplicateAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes when route urls specify a duplicate area prefix", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 15
 testRunner.When("I fetch the routes for the Areas controller\'s DuplicatePrefix action");
#line 16
 testRunner.Then("the route url is \"Area/DuplicatePrefix\"");
#line 17
 testRunner.When("I fetch the routes for the HttpAreas controller\'s DuplicatePrefix action");
#line 18
 testRunner.Then("the route url is \"ApiArea/DuplicatePrefix\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating absolute routes when a route area is defined")]
        public virtual void GeneratingAbsoluteRoutesWhenARouteAreaIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating absolute routes when a route area is defined", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 21
 testRunner.When("I fetch the routes for the Areas controller\'s Absolute action");
#line 22
 testRunner.Then("the route url is \"AreaAbsolute\"");
#line 23
 testRunner.When("I fetch the routes for the HttpAreas controller\'s Absolute action");
#line 24
 testRunner.Then("the route url is \"ApiAreaAbsolute\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes when route url starts with the area prefix")]
        public virtual void GeneratingAreaRoutesWhenRouteUrlStartsWithTheAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes when route url starts with the area prefix", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 27
 testRunner.When("I fetch the routes for the Areas controller\'s RouteBeginsWithAreaName action");
#line 28
 testRunner.Then("the route url is \"Area/Areas\"");
#line 29
 testRunner.When("I fetch the routes for the HttpAreas controller\'s RouteBeginsWithAreaName action");
#line 30
 testRunner.Then("the route url is \"ApiArea/ApiAreas\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes with an explicit area url")]
        public virtual void GeneratingAreaRoutesWithAnExplicitAreaUrl()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes with an explicit area url", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 33
 testRunner.When("I fetch the routes for the ExplicitAreaUrl controller\'s Index action");
#line 34
 testRunner.Then("the route url is \"ExplicitArea/Index\"");
#line 35
  testRunner.And("the data token for \"area\" is \"Area\"");
#line 36
 testRunner.When("I fetch the routes for the HttpExplicitAreaUrl controller\'s Get action");
#line 37
 testRunner.Then("the route url is \"ApiExplicitArea/Get\"");
#line 38
  testRunner.And("the data token for \"area\" is \"ApiArea\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating area routes with an explicit area url when route urls specify a duplic" +
            "ate area prefix")]
        public virtual void GeneratingAreaRoutesWithAnExplicitAreaUrlWhenRouteUrlsSpecifyADuplicateAreaPrefix()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating area routes with an explicit area url when route urls specify a duplic" +
                    "ate area prefix", ((string[])(null)));
#line 40
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 41
 testRunner.When("I fetch the routes for the ExplicitAreaUrl controller\'s DuplicatePrefix action");
#line 42
 testRunner.Then("the route url is \"ExplicitArea/DuplicatePrefix\"");
#line 43
  testRunner.And("the data token for \"area\" is \"Area\"");
#line 44
 testRunner.When("I fetch the routes for the HttpExplicitAreaUrl controller\'s DuplicatePrefix actio" +
                    "n");
#line 45
 testRunner.Then("the route url is \"ApiExplicitArea/DuplicatePrefix\"");
#line 46
  testRunner.And("the data token for \"area\" is \"ApiArea\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

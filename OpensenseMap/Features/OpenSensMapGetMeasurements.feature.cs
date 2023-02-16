﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace OpensenseMap.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("OpenSensMapGetMeasurements")]
    public partial class OpenSensMapGetMeasurementsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "OpenSensMapGetMeasurements.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "OpenSensMapGetMeasurements", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get list of Measurements form Box")]
        [NUnit.Framework.TestCaseAttribute("Measurements2.json", "json", "OK", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements2.json", "csv", "OK", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements2.json", "txt", "UnprocessableEntity", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements2.json", "json", "OK", "", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements.json", "", "OK", "", null)]
        public void GetListOfMeasurementsFormBox(string json, string jsonParam, string statusCode, string async, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("json", json);
            argumentsOfScenario.Add("jsonParam", jsonParam);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("async", async);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get list of Measurements form Box", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("Setup a new connection to endoint \'https://api.opensensemap.org/boxes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.And("Setup new POST request to endpint \'/data\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.And(string.Format("Open a json file \'{0}\' and prepare with parameters \'{1}\'", json, jsonParam), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And(string.Format("Send prepared POST requests {0}", async), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then(string.Format("Response status is \'{0}\'", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get list of Measurements form Box And Save it at database")]
        [NUnit.Framework.TestCaseAttribute("Measurements2.json", "json", "OK", "async", null)]
        public void GetListOfMeasurementsFormBoxAndSaveItAtDatabase(string json, string jsonParam, string statusCode, string async, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("json", json);
            argumentsOfScenario.Add("jsonParam", jsonParam);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("async", async);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get list of Measurements form Box And Save it at database", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given("Setup a new connection to endoint \'https://api.opensensemap.org/boxes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.And("Setup new POST request to endpint \'/data\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("Open a json file \'{0}\' and prepare with parameters \'{1}\'", json, jsonParam), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("Send prepared POST requests {0}", async), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.Then(string.Format("Response status is \'{0}\'", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Given("Connect to database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.Given("Insert to database first row of retured values", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 27
 testRunner.And("Select first row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get list of specific Measurements form Box")]
        [NUnit.Framework.TestCaseAttribute("Measurements3.json", "json;sensorId,createdAt,value,boxId,phenomenon", "OK", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements3.json", "json;sensorId,createdAt,value,boxId,phe", "UnprocessableEntity", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements3.json", "json;sensorId,createdAt,value,boxId,phenomenon,unit,boxName", "OK", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements3.json", "json;createdAt,value", "OK", "async", null)]
        [NUnit.Framework.TestCaseAttribute("Measurements3.json", "json;", "UnprocessableEntity", "async", null)]
        public void GetListOfSpecificMeasurementsFormBox(string json, string jsonParam, string statusCode, string async, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("json", json);
            argumentsOfScenario.Add("jsonParam", jsonParam);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("async", async);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get list of specific Measurements form Box", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given("Setup a new connection to endoint \'https://api.opensensemap.org/boxes/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
 testRunner.And("Setup new POST request to endpint \'/data\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And(string.Format("Open a json file \'{0}\' and prepare with parameters \'{1}\'", json, jsonParam), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And(string.Format("Send prepared POST requests {0}", async), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then(string.Format("Response status is \'{0}\'", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get last Measurements form Box")]
        [NUnit.Framework.TestCaseAttribute("", "OK", "5bb1dab2043f3f001ba31b69", null)]
        [NUnit.Framework.TestCaseAttribute("async", "OK", "5bb1dab2043f3f001ba31b69", null)]
        [NUnit.Framework.TestCaseAttribute("async", "NotFound", "5bb1dab2043f3f001ba31b6b", null)]
        public void GetLastMeasurementsFormBox(string async, string statusCode, string parameters, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("async", async);
            argumentsOfScenario.Add("statusCode", statusCode);
            argumentsOfScenario.Add("parameters", parameters);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get last Measurements form Box", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 47
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 48
 testRunner.Given("Setup a new connection to endoint \'https://api.opensensemap.org/boxes/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 49
 testRunner.And("Setup new GET request to endpint \'{0}/sensors\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Given(string.Format("Prepare get url using \'{0}\'", parameters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 52
 testRunner.And(string.Format("Send prepared GET requests {0}", async), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.Then(string.Format("Response status is \'{0}\'", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

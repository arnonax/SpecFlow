﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Different step arguments")]
    public partial class DifferentStepArgumentsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StepArguments.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Different step arguments", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can be defined without argument")]
        public virtual void StepsCanBeDefinedWithoutArgument()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can be defined without argument", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 4
 testRunner.Given("the following step definition", "[When(@\"I do something\")]\npublic void WhenIDoSomething()\n{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 11
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)));
#line 15
 testRunner.When("I execute the tests");
#line 16
 testRunner.Then("all tests should pass");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can be defined with table argument")]
        public virtual void StepsCanBeDefinedWithTableArgument()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can be defined with table argument", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 19
 testRunner.Given("the following step definition", "[When(@\"I do something\")]\npublic void WhenIDoSomething(Table table)\n{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 26
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\n| foo |\n| bar |", ((TechTalk.SpecFlow.Table)(null)));
#line 32
 testRunner.When("I execute the tests");
#line 33
 testRunner.Then("all tests should pass");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can be defined with multiline text argument")]
        public virtual void StepsCanBeDefinedWithMultilineTextArgument()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can be defined with multiline text argument", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 37
 testRunner.Given("the following step definition", "[When(@\"I do something\")]\npublic void WhenIDoSomething(string text)\n{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 44
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\n\'\'\'\n<Root>\n<Child attr=\"value\" />\n</Root>\n\'\'\'", ((TechTalk.SpecFlow.Table)(null)));
#line 53
 testRunner.When("I execute the tests");
#line 54
 testRunner.Then("all tests should pass");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps can be defined with both table and multiline text argument")]
        public virtual void StepsCanBeDefinedWithBothTableAndMultilineTextArgument()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps can be defined with both table and multiline text argument", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 58
 testRunner.Given("the following step definition", "[When(@\"I do something\")]\npublic void WhenIDoSomething(string text, Table table)\n" +
                    "{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 65
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\n\'\'\'\n<Root>\n<Child attr=\"value\" />\n</Root>\n\'\'\'\n| foo |\n| bar |" +
                    "", ((TechTalk.SpecFlow.Table)(null)));
#line 76
 testRunner.When("I execute the tests");
#line 77
 testRunner.Then("all tests should pass");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Step parameters in the step definitions have to be declared before the multiline " +
            "text and table parameters")]
        public virtual void StepParametersInTheStepDefinitionsHaveToBeDeclaredBeforeTheMultilineTextAndTableParameters()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Step parameters in the step definitions have to be declared before the multiline " +
                    "text and table parameters", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 80
 testRunner.Given("the following step definition", "[When(@\"I (.*) something\")]\npublic void WhenIDoSomething(string what, Table table" +
                    ")\n{\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 87
 testRunner.And("a scenario \'Simple Scenario\' as", "When I do something\n| foo |\n| bar |", ((TechTalk.SpecFlow.Table)(null)));
#line 93
 testRunner.When("I execute the tests");
#line 94
 testRunner.Then("all tests should pass");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion

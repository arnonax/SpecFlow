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
    [NUnit.Framework.DescriptionAttribute("Scoping step definitions")]
    public partial class ScopingStepDefinitionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScopedSteps.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scoping step definitions", @"As a developer
I would like to be able to scope the step definitions (bindings) on method and class level
So that I can implement test logic differently depending on the usage context

Attribute usage:

[Scope(Tag = ""mytag"", Feature = ""feature title"", Scenario = ""scenario title"")] 

Future ideas:
* scope for previous steps ([StepContext(Step = ""my previous step for doing something"")])
* use regex in scopes ([StepContext(Scenario = ""(my )?scenario title"")])", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Scoping step definitions to tags")]
        public virtual void ScopingStepDefinitionsToTags()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scoping step definitions to tags", ((string[])(null)));
#line 14
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 15
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 23
 testRunner.And("the following step definitions", "[When(\"I do something\"), Scope(Tag = \"mytag\")]\npublic void WhenIDoSomethingWithMy" +
                    "Tag()\n{}\n\n[When(\"I do something\"), Scope(Tag = \"othertag\")]\npublic void WhenIDoS" +
                    "omethingWithOtherTag()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 33
 testRunner.When("I execute the tests");
#line 34
 testRunner.Then("the binding method \'WhenIDoSomethingWithMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scoping step definitions to features")]
        public virtual void ScopingStepDefinitionsToFeatures()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scoping step definitions to features", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 37
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 43
 testRunner.And("the following step definitions", "[When(\"I do something\"), Scope(Feature = \"Simple Feature\")]\npublic void WhenIDoSo" +
                    "methingInSimpleFeature()\n{}\n\n[When(\"I do something\"), Scope(Feature = \"Other Fea" +
                    "ture\")]\npublic void WhenIDoSomethingInOtherFeature()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 53
 testRunner.When("I execute the tests");
#line 54
 testRunner.Then("the binding method \'WhenIDoSomethingInSimpleFeature\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scoping step definitions to scenarios")]
        public virtual void ScopingStepDefinitionsToScenarios()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scoping step definitions to scenarios", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 58
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 65
 testRunner.And("the following step definitions", "[When(\"I do something\"), Scope(Scenario = \"Simple Scenario\")]\npublic void WhenIDo" +
                    "SomethingInSimpleScenario()\n{}\n\n[When(\"I do something\"), Scope(Scenario = \"Other" +
                    " Scenario\")]\npublic void WhenIDoSomethingInOtherScenario()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 75
 testRunner.When("I execute the tests");
#line 76
 testRunner.Then("the binding method \'WhenIDoSomethingInSimpleScenario\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scopes can be conbined with AND")]
        public virtual void ScopesCanBeConbinedWithAND()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scopes can be conbined with AND", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 79
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 86
 testRunner.And("the following step definition", "[When(\"I do something\"), Scope(Feature = \"Simple Feature\", Tag = \"mytag\")]\npublic" +
                    " void WhenIDoSomethingInSimpleFeatureAndMyTag()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 92
 testRunner.When("I execute the tests");
#line 93
 testRunner.Then("the binding method \'WhenIDoSomethingInSimpleFeatureAndMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scopes can be conbined with OR")]
        public virtual void ScopesCanBeConbinedWithOR()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scopes can be conbined with OR", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 96
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n@mytag\nScenario: Simple Scenario\nWhen I do something\n\nSce" +
                    "nario: Other Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 106
 testRunner.And("the following step definition", "[When(\"I do something\"), Scope(Scenario = \"Other Scenario\"), Scope(Tag = \"mytag\")" +
                    "]\npublic void WhenIDoSomethingInOtherScenarioOrMyTag()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 112
 testRunner.When("I execute the tests");
#line 113
 testRunner.Then("the binding method \'WhenIDoSomethingInOtherScenarioOrMyTag\' is executed twice");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scoped matches have higher precedency")]
        public virtual void ScopedMatchesHaveHigherPrecedency()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scoped matches have higher precedency", ((string[])(null)));
#line 115
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 117
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 125
 testRunner.And("the following step definitions", "[When(\"I do something\"), Scope(Tag = \"mytag\")]\npublic void WhenIDoSomethingWithMy" +
                    "Tag()\n{}\n\n[When(\"I do something\")]\npublic void WhenIDoSomethingNonScoped()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 135
 testRunner.When("I execute the tests");
#line 136
 testRunner.Then("the binding method \'WhenIDoSomethingWithMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Scoping step definitions of a binding class")]
        public virtual void ScopingStepDefinitionsOfABindingClass()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Scoping step definitions of a binding class", ((string[])(null)));
#line 138
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 140
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 148
 testRunner.And("the following binding class", "[Binding, Scope(Tag = \"mytag\")]\npublic class ScopedSteps\n{\n[When(\"I do something\"" +
                    ")]\npublic void WhenIDoSomethingWithMyTag()\n{}\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 158
 testRunner.When("I execute the tests");
#line 159
 testRunner.Then("the binding method \'WhenIDoSomethingWithMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("No ambiguouity if the same method matches with multiple scopes")]
        public virtual void NoAmbiguouityIfTheSameMethodMatchesWithMultipleScopes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No ambiguouity if the same method matches with multiple scopes", ((string[])(null)));
#line 162
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 163
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 170
 testRunner.And("the following step definition", "[When(\"I do something\"), Scope(Scenario = \"Simple Scenario\"), Scope(Tag = \"mytag\"" +
                    ")]\npublic void WhenIDoSomethingInOtherScenarioOrMyTag()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 176
 testRunner.When("I execute the tests");
#line 177
 testRunner.Then("the binding method \'WhenIDoSomethingInOtherScenarioOrMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("More scope matches have higher precedency")]
        public virtual void MoreScopeMatchesHaveHigherPrecedency()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("More scope matches have higher precedency", ((string[])(null)));
#line 179
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 181
 testRunner.Given("there is a feature file in the project as", "Feature: Simple Feature\n@mytag\nScenario: Simple Scenario\nWhen I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 188
 testRunner.And("the following step definition", "[When(\"I do something\"), Scope(Feature = \"Simple Feature\", Tag = \"mytag\")]\npublic" +
                    " void WhenIDoSomethingInSimpleFeatureAndMyTag()\n{}\n[When(\"I do something\"), Scop" +
                    "e(Tag = \"mytag\")]\npublic void WhenIDoSomethingWithMyTag()\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 197
 testRunner.When("I execute the tests");
#line 198
 testRunner.Then("the binding method \'WhenIDoSomethingInSimpleFeatureAndMyTag\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion

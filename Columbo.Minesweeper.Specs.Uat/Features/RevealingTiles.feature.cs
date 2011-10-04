﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Columbo.Minesweeper.Specs.Uat.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Revealing Tiles")]
    public partial class RevealingTilesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RevealingTiles.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Revealing Tiles", "In order to identify mines\r\nAs a player \r\nI want to be able to click on a tile\r\na" +
                    "nd see how many mines surround that tile", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Click a tile on a minefield that contains one mine")]
        public virtual void ClickATileOnAMinefieldThatContainsOneMine()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Click a tile on a minefield that contains one mine", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have started a new game\twith a minefield size of 3 x 3");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Row",
                        "Column"});
            table1.AddRow(new string[] {
                        "1",
                        "1"});
#line 9
 testRunner.And("the minefield contains the following mines:", ((string)(null)), table1);
#line 12
 testRunner.When("I click on the tile at coordinate 0,0");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Row",
                        "Column"});
            table2.AddRow(new string[] {
                        "0",
                        "0"});
            table2.AddRow(new string[] {
                        "0",
                        "1"});
            table2.AddRow(new string[] {
                        "0",
                        "2"});
            table2.AddRow(new string[] {
                        "1",
                        "0"});
            table2.AddRow(new string[] {
                        "1",
                        "2"});
            table2.AddRow(new string[] {
                        "2",
                        "0"});
            table2.AddRow(new string[] {
                        "2",
                        "1"});
            table2.AddRow(new string[] {
                        "2",
                        "2"});
#line 13
 testRunner.Then("the following tiles should be revealed:", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Row",
                        "Column"});
            table3.AddRow(new string[] {
                        "1",
                        "1"});
#line 23
 testRunner.And("the following tiles should not be revealed:", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion

# CostOfTile
Use Fluxor for state management
Learn about Fluxor: https://github.com/mrpmorris/Fluxor/blob/master/Docs/README.md
Use it for all of our own frontend state, unless it causes major drawbacks. Not necessarily to recreate state that third party components handles itself
One state per feature (normally meaning page. For example separate state for Repack)
Use records for state. Prefer immutable types
States should be named. For example [FeatureState(Name = nameof(ConfirmQuantityPickedState))]
Use fluent validation in forms
Folder structure and naming conventions
All code that is specific for a feature should be contained within a folder in \Features\
Code that is used, or likely will be used across several features should be put in eManager.UI.Common
Feature folder structure. [Include a screenshot of example folder structure]
eManager.UI.App\Features
MyFeatureNameFeature (example RepackFeature)
Components: Subcomponents, not page components
Pages: Page components. Meaning all components that are using the @page directive. Filenames should end with Page. For example StockLedgerPage.razor
Store: All code related to Fluxor. Separate folders for Actions, Effects, Reducers, State. Files should be suffixed with the type, for example FetchStuffAction, FetchStuffEffect
ValidationModels: Fluent validation rules, edit models. Examples:
[name of the form]FormModel.cs. Ex. SearchFormModel.cs
[name of the form]FormValidation.cs. Ex. SearchFormValidation.cs
Models: Other models
Services. Services that are calling APIs etc.
Naming and folder structure conventions for Fluxor:
Separate classes/files for each reducer and effect
Several actions in one file is OK, but if you discover actions that can be grouped nicely together, put them in a separate file.
Use naming conventions from Fluxor tutorial: https://github.com/mrpmorris/Fluxor/blob/master/Docs/README.md
Some examples:
Actions: [something]Action. Example "SearchAction"
Reducer methods: Reduce[action name]. Example "ReduceSearchAction"
Effect methods: Handle[action name]. Example "HandleSearchAction"
Split up component code
Use separate file (MyComponent.razor.cs) for codebehind, instead of @code{} block in the razor file. An exception can be made for methods that generate markup, since this is better to do with razor than using rendertreebuilder in a C# file.
Put CSS in an isolated CSS file (MyComponent.razor.css). Avoid <style> block in the razor file
Styling and components use
Use Elements Design System or MudBlazor components if possible.
If you need to style MudBlazor/Elements Design System components: Stop and consider if this styling should be done in the Elements Design System repo instead, so it can be available for other teams.
Don't use inline styles
Use BEM naming convention: https://getbem.com/
Use nesting: https://developer.chrome.com/articles/css-nesting/

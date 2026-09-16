# How-to-show-the-dropdown-even-typed-text-is-not-available-in-DataSource

This Xamarin.Forms sample demonstrates how to display the **SfAutoComplete** dropdown even when the text entered by the user does not match any item in the underlying data source. By setting the `SuggestionMode` property to **Custom**, developers can implement custom filtering logic and control when suggestions are shown, regardless of whether matching records exist.

In many business applications, users may enter values that are not part of the available data source. In such scenarios, the default filtering behavior hides the suggestion dropdown when no matching items are found. This sample illustrates an approach where the dropdown can remain visible, allowing developers to present custom suggestions, recently selected items, or alternative options even when the typed text does not produce direct matches.

The sample uses the Syncfusion **SfAutoComplete** control and binds it to a collection of employee data. The control is configured with a custom suggestion mode so that suggestion generation can be handled manually. This provides greater flexibility over the filtering experience and enables advanced scenarios such as custom search logic, remote data loading, predictive suggestions, and displaying fallback items when no results are found.

## Features

- Displays suggestions using Syncfusion `SfAutoComplete`.
- Uses `SuggestionMode="Custom"` for complete control over filtering behavior.
- Keeps the dropdown visible even when the entered text does not match existing records.
- Supports custom suggestion handling.
- Demonstrates binding an AutoComplete control to a collection.
- Provides a foundation for implementing advanced search scenarios.

## Sample Behavior

1. The AutoComplete control is populated using a collection of employee records.
2. As the user types text, the control enters custom suggestion mode.
3. The application can determine how suggestions are filtered and displayed.
4. The dropdown can remain visible even when no matching item exists in the data source.
5. Developers can display alternative items, previous selections, or custom messages instead of hiding the dropdown.

## Sample

```xml
<autocomplete:SfAutoComplete
    x:Name="comboBox"
    HeightRequest="40"
    DisplayMemberPath="Name"
    SuggestionMode="Custom"
    MaximumDropDownHeight="200"
    DataSource="{Binding EmployeeCollection}" />
```

## Page Configuration

```xml
<ContentPage.BindingContext>
    <local:EmployeeViewModel/>
</ContentPage.BindingContext>
```

The AutoComplete control is bound to an `EmployeeViewModel` that provides the collection used as the data source.

## Key Properties

### DataSource

Specifies the collection used to populate the suggestions.

```xml
DataSource="{Binding EmployeeCollection}"
```

### DisplayMemberPath

Determines which property from the data object is displayed in the suggestion list.

```xml
DisplayMemberPath="Name"
```

### SuggestionMode

Enables developer-controlled filtering behavior.

```xml
SuggestionMode="Custom"
```

### MaximumDropDownHeight

Defines the maximum height of the dropdown list.

```xml
MaximumDropDownHeight="200"
```

## Use Cases

This sample is useful for applications that require:

- Custom search implementations.
- Intelligent suggestion systems.
- Showing recent searches.
- Displaying recommended items.
- Remote or server-side filtering.
- Maintaining dropdown visibility when no exact match exists.
- Enhanced user experience for data entry scenarios.

## Requirements

- Visual Studio 2019 or later
- Xamarin.Forms
- Syncfusion Xamarin AutoComplete control

## NuGet Package

```text
Syncfusion.Xamarin.SfAutoComplete
```

## Running the Sample

1. Clone or download the sample repository.
2. Restore all required NuGet packages.
3. Build the Xamarin.Forms application.
4. Deploy the application to an Android, iOS, or UWP device.
5. Type text into the AutoComplete control and observe how suggestions can be managed through custom filtering logic.

## Conclusion

This sample demonstrates how to configure Syncfusion `SfAutoComplete` to display suggestion dropdowns even when the entered text is not available in the bound data source. By using the `Custom` suggestion mode, developers gain full control over the filtering process and can create rich search experiences that go beyond standard AutoComplete behavior. The approach is particularly useful for applications that require flexible suggestion handling, custom search algorithms, or enhanced user guidance during data entry.
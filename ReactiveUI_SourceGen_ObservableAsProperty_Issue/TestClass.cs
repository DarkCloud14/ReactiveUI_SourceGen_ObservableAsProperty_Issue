using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveUI_SourceGen_ObservableAsProperty_Issue;

public partial class TestClass : ReactiveObject
{
    [ObservableAsProperty]
    private bool _observableTestField;

    public TestClass()
    {
    }

    [ObservableAsProperty]
    public partial bool ObservableTestProperty { get; }
}

using JetBrains.DataFlow;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Navigation.Goto.ProvidersAPI;
using JetBrains.UI.GotoByName;

namespace JetBrains.ReSharper.GoToWord.Navigation.Presentation
{
  [SolutionComponent]
  public class GotoWordModelInitializer : IModelInitializer
  {
    public void InitModel(Lifetime lifetime, GotoByNameModel model)
    {
      model.IsCheckBoxCheckerVisible.FlowInto(
        lifetime, model.CheckBoxText, flag => flag ? "Middle match" : string.Empty);

      model.CaptionText.Value = "Enter words:";
      model.NotReadyMessage.Value = "Some textual occurrences may be missing at the moment";
    }
  }
}
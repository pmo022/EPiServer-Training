@using $rootnamespace$
@model PageViewModel<$rootnamespace$.Models.Pages.StartPage>

@Html.PropertyFor(x => x.CurrentPage.MainContentArea, new { CssClass = "row equal-height", tag = Global.ContentAreaTags.FullWidth })

namespace BlazorApp.Pages;

partial class Dashboard
{
    private Timer _timer;

    public string Time { get; set; } = DateTime.Now.ToString();

    public Dashboard()
    {
        this._timer = new System.Threading.Timer(state =>
        {
            this.Time = DateTime.Now.ToString();
            this.StateHasChanged();
        }, null, 0, 1000);
    }
}

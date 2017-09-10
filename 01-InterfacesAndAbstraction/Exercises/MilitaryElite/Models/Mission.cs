public class Mission
{
    private string codeName;
    private string state;

    public Mission(string codeName, string state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public string State
    {
        get => this.state;
        private set
        {
            if (value != "inProgress" && value != "Finished")
            {
                this.state = "Invalid";
            }

            else this.state = value;
        }
    }

    public string CodeName
    {
        get => this.codeName;
        set { this.codeName = value; }
    }

    public void CompleteMission()
    {
        this.State = "Finished";
    }

    public override string ToString()
    {
        return $"Code Name: {this.CodeName} State: {this.State}";
    }
}

namespace TestingCodeConsoleApp
{
    public class GetContestPotentialWinnersQueryResult
    {
        public int Id { get; set; }
        public Vote_Data_Type DataLocationTableName { get; set; }
    }
    
    public enum Vote_Data_Type
    {
        sms,
        web,
        ivr
    }
}
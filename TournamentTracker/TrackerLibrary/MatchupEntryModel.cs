namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// one team in matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
   
        /// score of the team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// parent matchup  that the team  won 
        /// 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
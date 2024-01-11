namespace MonopolyWebApp.Models
{
    public class Branch
    {
        /// <summary>
        /// BranchId for Branch
        /// </summary>
        public int BranchdID { get; set; }

        /// <summary>
        /// BoardId for Branch
        /// </summary>
        public int BoardID { get; set; }

        /// <summary>
        /// CardId for Branch
        /// </summary>
        public int CardId { get; set; }

        /// <summary>
        /// BranchHouses of Branch
        /// </summary>
        public int BranchHouses { get; set; }

        /// <summary>
        /// BranchName of Branch
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// BranchCards of Branch
        /// </summary>
        public string BranchCards { get; set; }
    }
}

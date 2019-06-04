using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Voting
    {
        public int VotingId { get; set; }
        public string VotingName { get; set; }

        public List<VoteOption> Options { get; set; }

        public Voting(int votingId,string votingName,List<VoteOption> voteOptions)
        {
            this.VotingId = votingId;
            this.VotingName = votingName;
            this.Options = voteOptions;
        }
    }
    public class VoteOption
    {
        public int Vote { get; set; }
        public string Option { get; set; }

        public VoteOption(int vote,string option)
        {
            this.Vote = vote;
            this.Option = option;
        }
    }
}
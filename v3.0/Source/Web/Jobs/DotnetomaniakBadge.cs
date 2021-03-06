using System;
using Kigg.LinqToSql.Repository;

namespace Kigg.Web.Jobs
{
    public class DotnetomaniakBadge : AwardBadgeJob
    {
        public Guid Id = new Guid("C5217D3A-1CA1-4C49-9E4C-990C63CD7176");
        protected override void AwardBadges(IDatabaseFactory databaseFactory)
        {
            databaseFactory.Get().Dotnetomaniak();
        }

        protected override TimeSpan Interval
        {
            get { return new TimeSpan(0, 2, 0); }
        }
    }
}
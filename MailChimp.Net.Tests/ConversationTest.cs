﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConversationTest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using System.Threading.Tasks;

using MailChimp.Net.Core;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MailChimp.Net.Tests
{
    /// <summary>
    /// The campaign test.
    /// </summary>
    [TestClass]
    public class CampaignTest : MailChimpTest
    {
        /// <summary>
        /// The should_ get_ one_ campain_ id_ and_ get_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Get_One_Campain_Id_And_Get_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);

            var campaign = await this._mailChimpManager.Campaigns.GetAsync(campaigns.FirstOrDefault().Id);

            Assert.IsNotNull(campaign);
        }

        /// <summary>
        /// The should_ return_ campaigns.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_Campaigns()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll();
            Assert.IsNotNull(campaigns);
        }

        /// <summary>
        /// The should_ return_ one_ campaign.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [TestMethod]
        public async Task Should_Return_One_Campaign()
        {
            var campaigns = await this._mailChimpManager.Campaigns.GetAll(new CampaignRequest { Limit = 1 });
            Assert.IsTrue(campaigns.Count() == 1);
        }
    }
}
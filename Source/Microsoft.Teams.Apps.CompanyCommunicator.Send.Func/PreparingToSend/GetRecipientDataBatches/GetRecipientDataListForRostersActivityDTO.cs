﻿// <copyright file="GetRecipientDataListForRostersActivityDTO.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Send.Func.PreparingToSend.GetRecipientDataBatches
{
    using Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.TeamData;

    /// <summary>
    /// DTO class used by the GetRecipientDataListForRostersActivity as parameter type.
    /// </summary>
    public class GetRecipientDataListForRostersActivityDTO
    {
        /// <summary>
        /// Gets or sets notification data entity id.
        /// </summary>
        public string NotificationDataEntityId { get; set; }

        /// <summary>
        /// Gets or sets team data entity.
        /// </summary>
        public TeamDataEntity TeamDataEntity { get; set; }
    }
}
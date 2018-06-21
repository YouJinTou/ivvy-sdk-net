﻿using Ivvy.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ivvy
{
    public partial interface IApi
    {
        /// <summary>
        /// Returns the list of custom field definitions in an account.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<CustomField>>> GetCustomFieldDefinition();

        /// <summary>
        /// Returns the list of subscription groups in an account.
        /// </summary>
        /// <returns></returns>
        Task<ResultOrError<List<SubscriptionGroup>>> GetSubscriptionGroupListAsync();

        /// <summary>
        /// Returns a collection of emails in an account.
        /// </summary>
        /// <param name="perPage">The per page.</param>
        /// <param name="start">The start.</param>
        /// <param name="filterRequest">The filter request.</param>
        /// <returns></returns>
        Task<ResultOrError<ResultList<EmailLog>>> GetEmailLogList(
            int perPage,
            int start,
            Dictionary<string, string> filterRequest);
    }
}
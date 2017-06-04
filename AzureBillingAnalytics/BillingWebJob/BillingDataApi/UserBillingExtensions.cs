﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace BillingWebJob
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for UserBilling.
    /// </summary>
    public static partial class UserBillingExtensions
    {
            /// <summary>
            /// Api which returns usage records for an azure subscription for the current
            /// month.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<UsageInfoModel> GetCurrentMonthData(this IUserBilling operations)
            {
                return Task.Factory.StartNew(s => ((IUserBilling)s).GetCurrentMonthDataAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Api which returns usage records for an azure subscription for the current
            /// month.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<UsageInfoModel>> GetCurrentMonthDataAsync(this IUserBilling operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCurrentMonthDataWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Api which returns usage records for an azure subscription for the given
            /// month.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='monthYear'>
            /// Provide month and year in "mm-yyyy" format. Example: "02-2016".
            /// </param>
            public static IList<UsageInfoModel> GetSingleMonthData(this IUserBilling operations, string monthYear)
            {
                return Task.Factory.StartNew(s => ((IUserBilling)s).GetSingleMonthDataAsync(monthYear), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Api which returns usage records for an azure subscription for the given
            /// month.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='monthYear'>
            /// Provide month and year in "mm-yyyy" format. Example: "02-2016".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<UsageInfoModel>> GetSingleMonthDataAsync(this IUserBilling operations, string monthYear, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSingleMonthDataWithHttpMessagesAsync(monthYear, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Api which returns usage records for an azure subscription for the given
            /// month range.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startMonthYear'>
            /// Provide month and year in "yyyymm" format. Example: "022015".
            /// </param>
            /// <param name='endMonthYear'>
            /// Provide month and year in "yyyymm" format. Example: "122016".
            /// </param>
            public static IList<UsageInfoModel> GetDataForMonthRange(this IUserBilling operations, string startMonthYear, string endMonthYear)
            {
                return Task.Factory.StartNew(s => ((IUserBilling)s).GetDataForMonthRangeAsync(startMonthYear, endMonthYear), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Api which returns usage records for an azure subscription for the given
            /// month range.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startMonthYear'>
            /// Provide month and year in "yyyymm" format. Example: "022015".
            /// </param>
            /// <param name='endMonthYear'>
            /// Provide month and year in "yyyymm" format. Example: "122016".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<UsageInfoModel>> GetDataForMonthRangeAsync(this IUserBilling operations, string startMonthYear, string endMonthYear, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDataForMonthRangeWithHttpMessagesAsync(startMonthYear, endMonthYear, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using Newtonsoft.Json.Linq;

namespace BillingWebJob.Models
{
    public partial class CspUsageLineItem
    {
        private string _billingProvider;

        /// <summary>
        /// Optional.
        /// </summary>
        public string BillingProvider
        {
            get { return this._billingProvider; }
            set { this._billingProvider = value; }
        }

        private DateTimeOffset? _chargeEndDate;

        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? ChargeEndDate
        {
            get { return this._chargeEndDate; }
            set { this._chargeEndDate = value; }
        }

        private DateTimeOffset? _chargeStartDate;

        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? ChargeStartDate
        {
            get { return this._chargeStartDate; }
            set { this._chargeStartDate = value; }
        }

        private double? _consumedQuantity;

        /// <summary>
        /// Optional.
        /// </summary>
        public double? ConsumedQuantity
        {
            get { return this._consumedQuantity; }
            set { this._consumedQuantity = value; }
        }

        private string _customerBillableAccount;

        /// <summary>
        /// Optional.
        /// </summary>
        public string CustomerBillableAccount
        {
            get { return this._customerBillableAccount; }
            set { this._customerBillableAccount = value; }
        }

        private string _customerCompanyName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string CustomerCompanyName
        {
            get { return this._customerCompanyName; }
            set { this._customerCompanyName = value; }
        }

        private int? _id;

        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private string _invoiceNumber;

        /// <summary>
        /// Optional.
        /// </summary>
        public string InvoiceNumber
        {
            get { return this._invoiceNumber; }
            set { this._invoiceNumber = value; }
        }

        private string _mpnId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string MpnId
        {
            get { return this._mpnId; }
            set { this._mpnId = value; }
        }

        private string _orderId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string OrderId
        {
            get { return this._orderId; }
            set { this._orderId = value; }
        }

        private string _partnerBillableAccountId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string PartnerBillableAccountId
        {
            get { return this._partnerBillableAccountId; }
            set { this._partnerBillableAccountId = value; }
        }

        private string _partnerId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string PartnerId
        {
            get { return this._partnerId; }
            set { this._partnerId = value; }
        }

        private string _partnerName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string PartnerName
        {
            get { return this._partnerName; }
            set { this._partnerName = value; }
        }

        private string _region;

        /// <summary>
        /// Optional.
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        private string _resourceGuid;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ResourceGuid
        {
            get { return this._resourceGuid; }
            set { this._resourceGuid = value; }
        }

        private string _resourceName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        private string _serviceName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        private string _serviceType;

        /// <summary>
        /// Optional.
        /// </summary>
        public string ServiceType
        {
            get { return this._serviceType; }
            set { this._serviceType = value; }
        }

        private string _subscriptionDescription;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionDescription
        {
            get { return this._subscriptionDescription; }
            set { this._subscriptionDescription = value; }
        }

        private string _subscriptionId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        private string _subscriptionName;

        /// <summary>
        /// Optional.
        /// </summary>
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        private string _tierMpnId;

        /// <summary>
        /// Optional.
        /// </summary>
        public string TierMpnId
        {
            get { return this._tierMpnId; }
            set { this._tierMpnId = value; }
        }

        private DateTimeOffset? _usageDate;

        /// <summary>
        /// Optional.
        /// </summary>
        public DateTimeOffset? UsageDate
        {
            get { return this._usageDate; }
            set { this._usageDate = value; }
        }

        /// <summary>
        /// Initializes a new instance of the CspUsageLineItem class.
        /// </summary>
        public CspUsageLineItem()
        {
        }

        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken billingProviderValue = inputObject["BillingProvider"];
                if (billingProviderValue != null && billingProviderValue.Type != JTokenType.Null)
                {
                    this.BillingProvider = ((string) billingProviderValue);
                }
                JToken chargeEndDateValue = inputObject["ChargeEndDate"];
                if (chargeEndDateValue != null && chargeEndDateValue.Type != JTokenType.Null)
                {
                    this.ChargeEndDate = ((DateTimeOffset) chargeEndDateValue);
                }
                JToken chargeStartDateValue = inputObject["ChargeStartDate"];
                if (chargeStartDateValue != null && chargeStartDateValue.Type != JTokenType.Null)
                {
                    this.ChargeStartDate = ((DateTimeOffset) chargeStartDateValue);
                }
                JToken consumedQuantityValue = inputObject["ConsumedQuantity"];
                if (consumedQuantityValue != null && consumedQuantityValue.Type != JTokenType.Null)
                {
                    this.ConsumedQuantity = ((double) consumedQuantityValue);
                }
                JToken customerBillableAccountValue = inputObject["CustomerBillableAccount"];
                if (customerBillableAccountValue != null && customerBillableAccountValue.Type != JTokenType.Null)
                {
                    this.CustomerBillableAccount = ((string) customerBillableAccountValue);
                }
                JToken customerCompanyNameValue = inputObject["CustomerCompanyName"];
                if (customerCompanyNameValue != null && customerCompanyNameValue.Type != JTokenType.Null)
                {
                    this.CustomerCompanyName = ((string) customerCompanyNameValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int) idValue);
                }
                JToken invoiceNumberValue = inputObject["invoiceNumber"];
                if (invoiceNumberValue != null && invoiceNumberValue.Type != JTokenType.Null)
                {
                    this.InvoiceNumber = ((string) invoiceNumberValue);
                }
                JToken mpnIdValue = inputObject["MpnId"];
                if (mpnIdValue != null && mpnIdValue.Type != JTokenType.Null)
                {
                    this.MpnId = ((string) mpnIdValue);
                }
                JToken orderIdValue = inputObject["orderId"];
                if (orderIdValue != null && orderIdValue.Type != JTokenType.Null)
                {
                    this.OrderId = ((string) orderIdValue);
                }
                JToken partnerBillableAccountIdValue = inputObject["PartnerBillableAccountId"];
                if (partnerBillableAccountIdValue != null && partnerBillableAccountIdValue.Type != JTokenType.Null)
                {
                    this.PartnerBillableAccountId = ((string) partnerBillableAccountIdValue);
                }
                JToken partnerIdValue = inputObject["PartnerId"];
                if (partnerIdValue != null && partnerIdValue.Type != JTokenType.Null)
                {
                    this.PartnerId = ((string) partnerIdValue);
                }
                JToken partnerNameValue = inputObject["PartnerName"];
                if (partnerNameValue != null && partnerNameValue.Type != JTokenType.Null)
                {
                    this.PartnerName = ((string) partnerNameValue);
                }
                JToken regionValue = inputObject["Region"];
                if (regionValue != null && regionValue.Type != JTokenType.Null)
                {
                    this.Region = ((string) regionValue);
                }
                JToken resourceGuidValue = inputObject["ResourceGuid"];
                if (resourceGuidValue != null && resourceGuidValue.Type != JTokenType.Null)
                {
                    this.ResourceGuid = ((string) resourceGuidValue);
                }
                JToken resourceNameValue = inputObject["ResourceName"];
                if (resourceNameValue != null && resourceNameValue.Type != JTokenType.Null)
                {
                    this.ResourceName = ((string) resourceNameValue);
                }
                JToken serviceNameValue = inputObject["ServiceName"];
                if (serviceNameValue != null && serviceNameValue.Type != JTokenType.Null)
                {
                    this.ServiceName = ((string) serviceNameValue);
                }
                JToken serviceTypeValue = inputObject["ServiceType"];
                if (serviceTypeValue != null && serviceTypeValue.Type != JTokenType.Null)
                {
                    this.ServiceType = ((string) serviceTypeValue);
                }
                JToken subscriptionDescriptionValue = inputObject["SubscriptionDescription"];
                if (subscriptionDescriptionValue != null && subscriptionDescriptionValue.Type != JTokenType.Null)
                {
                    this.SubscriptionDescription = ((string) subscriptionDescriptionValue);
                }
                JToken subscriptionIdValue = inputObject["SubscriptionId"];
                if (subscriptionIdValue != null && subscriptionIdValue.Type != JTokenType.Null)
                {
                    this.SubscriptionId = ((string) subscriptionIdValue);
                }
                JToken subscriptionNameValue = inputObject["SubscriptionName"];
                if (subscriptionNameValue != null && subscriptionNameValue.Type != JTokenType.Null)
                {
                    this.SubscriptionName = ((string) subscriptionNameValue);
                }
                JToken tierMpnIdValue = inputObject["TierMpnId"];
                if (tierMpnIdValue != null && tierMpnIdValue.Type != JTokenType.Null)
                {
                    this.TierMpnId = ((string) tierMpnIdValue);
                }
                JToken usageDateValue = inputObject["UsageDate"];
                if (usageDateValue != null && usageDateValue.Type != JTokenType.Null)
                {
                    this.UsageDate = ((DateTimeOffset) usageDateValue);
                }
            }
        }
    }
}
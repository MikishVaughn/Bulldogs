'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ASPSMSX2
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="https://webservice.aspsms.com/aspsmsx2.asmx", ConfigurationName:="ASPSMSX2.ASPSMSX2Soap")>  _
    Public Interface ASPSMSX2Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SimpleWAPPush", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SimpleWAPPush(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal WapDescription As String, ByVal WapURL As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SimpleWAPPush", ReplyAction:="*")>  _
        Function SimpleWAPPushAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal WapDescription As String, ByVal WapURL As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendSimpleTextSMS", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SendSimpleTextSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendSimpleTextSMS", ReplyAction:="*")>  _
        Function SendSimpleTextSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendTextSMS", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SendTextSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendTextSMS", ReplyAction:="*")>  _
        Function SendTextSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendUnicodeSMS", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SendUnicodeSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendUnicodeSMS", ReplyAction:="*")>  _
        Function SendUnicodeSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CheckCredits", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CheckCredits(ByVal UserKey As String, ByVal Password As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CheckCredits", ReplyAction:="*")>  _
        Function CheckCreditsAsync(ByVal UserKey As String, ByVal Password As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendOriginatorUnlockCode", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SendOriginatorUnlockCode(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendOriginatorUnlockCode", ReplyAction:="*")>  _
        Function SendOriginatorUnlockCodeAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/UnlockOriginator", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function UnlockOriginator(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal OriginatorUnlockCode As String, ByVal AffiliateId As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/UnlockOriginator", ReplyAction:="*")>  _
        Function UnlockOriginatorAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal OriginatorUnlockCode As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CheckOriginatorAuthorization", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CheckOriginatorAuthorization(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CheckOriginatorAuthorization", ReplyAction:="*")>  _
        Function CheckOriginatorAuthorizationAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/VerifyToken", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function VerifyToken(ByVal UserKey As String, ByVal Password As String, ByVal PhoneNumber As String, ByVal TokenReference As String, ByVal VerificationCode As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/VerifyToken", ReplyAction:="*")>  _
        Function VerifyTokenAsync(ByVal UserKey As String, ByVal Password As String, ByVal PhoneNumber As String, ByVal TokenReference As String, ByVal VerificationCode As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendTokenSMS", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function SendTokenSMS(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal Recipients As String, ByVal MessageData As String, ByVal TokenReference As String, ByVal TokenValidity As String, ByVal TokenMask As String, ByVal VerificationCode As String, ByVal TokenCaseSensitive As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/SendTokenSMS", ReplyAction:="*")>  _
        Function SendTokenSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal Recipients As String, ByVal MessageData As String, ByVal TokenReference As String, ByVal TokenValidity As String, ByVal TokenMask As String, ByVal VerificationCode As String, ByVal TokenCaseSensitive As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/InquireDeliveryNotifications", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function InquireDeliveryNotifications(ByVal UserKey As String, ByVal Password As String, ByVal TransactionReferenceNumbers As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/InquireDeliveryNotifications", ReplyAction:="*")>  _
        Function InquireDeliveryNotificationsAsync(ByVal UserKey As String, ByVal Password As String, ByVal TransactionReferenceNumbers As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/RedeemVoucher", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function RedeemVoucher(ByVal UserKey As String, ByVal Password As String, ByVal RedeemCode As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/RedeemVoucher", ReplyAction:="*")>  _
        Function RedeemVoucherAsync(ByVal UserKey As String, ByVal Password As String, ByVal RedeemCode As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CreateVoucher", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CreateVoucher(ByVal UserKey As String, ByVal Password As String, ByVal NumberOfVouchers As String, ByVal AmountCreditsPerVoucher As String, ByVal Remarks As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/CreateVoucher", ReplyAction:="*")>  _
        Function CreateVoucherAsync(ByVal UserKey As String, ByVal Password As String, ByVal NumberOfVouchers As String, ByVal AmountCreditsPerVoucher As String, ByVal Remarks As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/GetVoucherTransactions", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetVoucherTransactions(ByVal UserKey As String, ByVal Password As String) As ASPSMSX2.vouchers()
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/GetVoucherTransactions", ReplyAction:="*")>  _
        Function GetVoucherTransactionsAsync(ByVal UserKey As String, ByVal Password As String) As System.Threading.Tasks.Task(Of ASPSMSX2.vouchers())
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/GetStatusCodeDescription", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function GetStatusCodeDescription(ByVal StatusCode As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/GetStatusCodeDescription", ReplyAction:="*")>  _
        Function GetStatusCodeDescriptionAsync(ByVal StatusCode As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/VersionInfo", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function VersionInfo() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="https://webservice.aspsms.com/aspsmsx2.asmx/VersionInfo", ReplyAction:="*")>  _
        Function VersionInfoAsync() As System.Threading.Tasks.Task(Of String)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4161.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="https://webservice.aspsms.com/aspsmsx2.asmx")>  _
    Partial Public Class vouchers
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private voucherCodeField As String
        
        Private remarkField As String
        
        Private creditsField As String
        
        Private createdField As String
        
        Private redeemedField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property VoucherCode() As String
            Get
                Return Me.voucherCodeField
            End Get
            Set
                Me.voucherCodeField = value
                Me.RaisePropertyChanged("VoucherCode")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property Remark() As String
            Get
                Return Me.remarkField
            End Get
            Set
                Me.remarkField = value
                Me.RaisePropertyChanged("Remark")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property Credits() As String
            Get
                Return Me.creditsField
            End Get
            Set
                Me.creditsField = value
                Me.RaisePropertyChanged("Credits")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=3)>  _
        Public Property Created() As String
            Get
                Return Me.createdField
            End Get
            Set
                Me.createdField = value
                Me.RaisePropertyChanged("Created")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=4)>  _
        Public Property Redeemed() As String
            Get
                Return Me.redeemedField
            End Get
            Set
                Me.redeemedField = value
                Me.RaisePropertyChanged("Redeemed")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ASPSMSX2SoapChannel
        Inherits ASPSMSX2.ASPSMSX2Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ASPSMSX2SoapClient
        Inherits System.ServiceModel.ClientBase(Of ASPSMSX2.ASPSMSX2Soap)
        Implements ASPSMSX2.ASPSMSX2Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function SimpleWAPPush(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal WapDescription As String, ByVal WapURL As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SimpleWAPPush
            Return MyBase.Channel.SimpleWAPPush(UserKey, Password, Recipients, Originator, WapDescription, WapURL, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SimpleWAPPushAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal WapDescription As String, ByVal WapURL As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SimpleWAPPushAsync
            Return MyBase.Channel.SimpleWAPPushAsync(UserKey, Password, Recipients, Originator, WapDescription, WapURL, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SendSimpleTextSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SendSimpleTextSMS
            Return MyBase.Channel.SendSimpleTextSMS(UserKey, Password, Recipients, Originator, MessageText)
        End Function
        
        Public Function SendSimpleTextSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SendSimpleTextSMSAsync
            Return MyBase.Channel.SendSimpleTextSMSAsync(UserKey, Password, Recipients, Originator, MessageText)
        End Function
        
        Public Function SendTextSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SendTextSMS
            Return MyBase.Channel.SendTextSMS(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SendTextSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SendTextSMSAsync
            Return MyBase.Channel.SendTextSMSAsync(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SendUnicodeSMS(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SendUnicodeSMS
            Return MyBase.Channel.SendUnicodeSMS(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SendUnicodeSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Recipients As String, ByVal Originator As String, ByVal MessageText As String, ByVal DeferredDeliveryTime As String, ByVal FlashingSMS As String, ByVal TimeZone As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SendUnicodeSMSAsync
            Return MyBase.Channel.SendUnicodeSMSAsync(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function CheckCredits(ByVal UserKey As String, ByVal Password As String) As String Implements ASPSMSX2.ASPSMSX2Soap.CheckCredits
            Return MyBase.Channel.CheckCredits(UserKey, Password)
        End Function
        
        Public Function CheckCreditsAsync(ByVal UserKey As String, ByVal Password As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.CheckCreditsAsync
            Return MyBase.Channel.CheckCreditsAsync(UserKey, Password)
        End Function
        
        Public Function SendOriginatorUnlockCode(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SendOriginatorUnlockCode
            Return MyBase.Channel.SendOriginatorUnlockCode(UserKey, Password, Originator)
        End Function
        
        Public Function SendOriginatorUnlockCodeAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SendOriginatorUnlockCodeAsync
            Return MyBase.Channel.SendOriginatorUnlockCodeAsync(UserKey, Password, Originator)
        End Function
        
        Public Function UnlockOriginator(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal OriginatorUnlockCode As String, ByVal AffiliateId As String) As String Implements ASPSMSX2.ASPSMSX2Soap.UnlockOriginator
            Return MyBase.Channel.UnlockOriginator(UserKey, Password, Originator, OriginatorUnlockCode, AffiliateId)
        End Function
        
        Public Function UnlockOriginatorAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal OriginatorUnlockCode As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.UnlockOriginatorAsync
            Return MyBase.Channel.UnlockOriginatorAsync(UserKey, Password, Originator, OriginatorUnlockCode, AffiliateId)
        End Function
        
        Public Function CheckOriginatorAuthorization(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As String Implements ASPSMSX2.ASPSMSX2Soap.CheckOriginatorAuthorization
            Return MyBase.Channel.CheckOriginatorAuthorization(UserKey, Password, Originator)
        End Function
        
        Public Function CheckOriginatorAuthorizationAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.CheckOriginatorAuthorizationAsync
            Return MyBase.Channel.CheckOriginatorAuthorizationAsync(UserKey, Password, Originator)
        End Function
        
        Public Function VerifyToken(ByVal UserKey As String, ByVal Password As String, ByVal PhoneNumber As String, ByVal TokenReference As String, ByVal VerificationCode As String) As String Implements ASPSMSX2.ASPSMSX2Soap.VerifyToken
            Return MyBase.Channel.VerifyToken(UserKey, Password, PhoneNumber, TokenReference, VerificationCode)
        End Function
        
        Public Function VerifyTokenAsync(ByVal UserKey As String, ByVal Password As String, ByVal PhoneNumber As String, ByVal TokenReference As String, ByVal VerificationCode As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.VerifyTokenAsync
            Return MyBase.Channel.VerifyTokenAsync(UserKey, Password, PhoneNumber, TokenReference, VerificationCode)
        End Function
        
        Public Function SendTokenSMS(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal Recipients As String, ByVal MessageData As String, ByVal TokenReference As String, ByVal TokenValidity As String, ByVal TokenMask As String, ByVal VerificationCode As String, ByVal TokenCaseSensitive As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As String Implements ASPSMSX2.ASPSMSX2Soap.SendTokenSMS
            Return MyBase.Channel.SendTokenSMS(UserKey, Password, Originator, Recipients, MessageData, TokenReference, TokenValidity, TokenMask, VerificationCode, TokenCaseSensitive, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function SendTokenSMSAsync(ByVal UserKey As String, ByVal Password As String, ByVal Originator As String, ByVal Recipients As String, ByVal MessageData As String, ByVal TokenReference As String, ByVal TokenValidity As String, ByVal TokenMask As String, ByVal VerificationCode As String, ByVal TokenCaseSensitive As String, ByVal URLBufferedMessageNotification As String, ByVal URLDeliveryNotification As String, ByVal URLNonDeliveryNotification As String, ByVal AffiliateId As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.SendTokenSMSAsync
            Return MyBase.Channel.SendTokenSMSAsync(UserKey, Password, Originator, Recipients, MessageData, TokenReference, TokenValidity, TokenMask, VerificationCode, TokenCaseSensitive, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId)
        End Function
        
        Public Function InquireDeliveryNotifications(ByVal UserKey As String, ByVal Password As String, ByVal TransactionReferenceNumbers As String) As String Implements ASPSMSX2.ASPSMSX2Soap.InquireDeliveryNotifications
            Return MyBase.Channel.InquireDeliveryNotifications(UserKey, Password, TransactionReferenceNumbers)
        End Function
        
        Public Function InquireDeliveryNotificationsAsync(ByVal UserKey As String, ByVal Password As String, ByVal TransactionReferenceNumbers As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.InquireDeliveryNotificationsAsync
            Return MyBase.Channel.InquireDeliveryNotificationsAsync(UserKey, Password, TransactionReferenceNumbers)
        End Function
        
        Public Function RedeemVoucher(ByVal UserKey As String, ByVal Password As String, ByVal RedeemCode As String) As String Implements ASPSMSX2.ASPSMSX2Soap.RedeemVoucher
            Return MyBase.Channel.RedeemVoucher(UserKey, Password, RedeemCode)
        End Function
        
        Public Function RedeemVoucherAsync(ByVal UserKey As String, ByVal Password As String, ByVal RedeemCode As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.RedeemVoucherAsync
            Return MyBase.Channel.RedeemVoucherAsync(UserKey, Password, RedeemCode)
        End Function
        
        Public Function CreateVoucher(ByVal UserKey As String, ByVal Password As String, ByVal NumberOfVouchers As String, ByVal AmountCreditsPerVoucher As String, ByVal Remarks As String) As String Implements ASPSMSX2.ASPSMSX2Soap.CreateVoucher
            Return MyBase.Channel.CreateVoucher(UserKey, Password, NumberOfVouchers, AmountCreditsPerVoucher, Remarks)
        End Function
        
        Public Function CreateVoucherAsync(ByVal UserKey As String, ByVal Password As String, ByVal NumberOfVouchers As String, ByVal AmountCreditsPerVoucher As String, ByVal Remarks As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.CreateVoucherAsync
            Return MyBase.Channel.CreateVoucherAsync(UserKey, Password, NumberOfVouchers, AmountCreditsPerVoucher, Remarks)
        End Function
        
        Public Function GetVoucherTransactions(ByVal UserKey As String, ByVal Password As String) As ASPSMSX2.vouchers() Implements ASPSMSX2.ASPSMSX2Soap.GetVoucherTransactions
            Return MyBase.Channel.GetVoucherTransactions(UserKey, Password)
        End Function
        
        Public Function GetVoucherTransactionsAsync(ByVal UserKey As String, ByVal Password As String) As System.Threading.Tasks.Task(Of ASPSMSX2.vouchers()) Implements ASPSMSX2.ASPSMSX2Soap.GetVoucherTransactionsAsync
            Return MyBase.Channel.GetVoucherTransactionsAsync(UserKey, Password)
        End Function
        
        Public Function GetStatusCodeDescription(ByVal StatusCode As String) As String Implements ASPSMSX2.ASPSMSX2Soap.GetStatusCodeDescription
            Return MyBase.Channel.GetStatusCodeDescription(StatusCode)
        End Function
        
        Public Function GetStatusCodeDescriptionAsync(ByVal StatusCode As String) As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.GetStatusCodeDescriptionAsync
            Return MyBase.Channel.GetStatusCodeDescriptionAsync(StatusCode)
        End Function
        
        Public Function VersionInfo() As String Implements ASPSMSX2.ASPSMSX2Soap.VersionInfo
            Return MyBase.Channel.VersionInfo
        End Function
        
        Public Function VersionInfoAsync() As System.Threading.Tasks.Task(Of String) Implements ASPSMSX2.ASPSMSX2Soap.VersionInfoAsync
            Return MyBase.Channel.VersionInfoAsync
        End Function
    End Class
End Namespace

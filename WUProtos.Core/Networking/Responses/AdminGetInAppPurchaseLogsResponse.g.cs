// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WUProtos/Networking/Responses/AdminGetInAppPurchaseLogsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WUProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from WUProtos/Networking/Responses/AdminGetInAppPurchaseLogsResponse.proto</summary>
  public static partial class AdminGetInAppPurchaseLogsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for WUProtos/Networking/Responses/AdminGetInAppPurchaseLogsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdminGetInAppPurchaseLogsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVXVVByb3Rvcy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9BZG1pbkdldEluQXBw",
            "UHVyY2hhc2VMb2dzUmVzcG9uc2UucHJvdG8SHVdVUHJvdG9zLk5ldHdvcmtp",
            "bmcuUmVzcG9uc2VzIuMFCiFBZG1pbkdldEluQXBwUHVyY2hhc2VMb2dzUmVz",
            "cG9uc2USZAoDbG9nGAEgAygLMlcuV1VQcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMuQWRtaW5HZXRJbkFwcFB1cmNoYXNlTG9nc1Jlc3BvbnNlLlBsYXll",
            "ckluQXBwUHVyY2hhc2VMb2cSbgoPY3VycmVudF9iYWxhbmNlGAIgAygLMlUu",
            "V1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQWRtaW5HZXRJbkFwcFB1",
            "cmNoYXNlTG9nc1Jlc3BvbnNlLkJhbGFuY2VTbmFwc2hvdEVudHJ5Gj8KFEJh",
            "bGFuY2VTbmFwc2hvdEVudHJ5EhUKDWN1cnJlbmN5X3R5cGUYASABKAkSEAoI",
            "cXVhbnRpdHkYAiABKAUapgMKFlBsYXllckluQXBwUHVyY2hhc2VMb2cSFAoM",
            "dGltZXN0YW1wX21zGAEgASgDEhEKCXBsYXllcl9pZBgCIAEoCRIMCgR0eXBl",
            "GAMgASgJEhMKC2Rlc2NyaXB0aW9uGAQgASgJEg4KBnNrdV9pZBgFIAEoCRIV",
            "Cg1jdXJyZW5jeV91c2VkGAYgASgJEhUKDXByaWNlX3BhaWRfZTYYByABKAMS",
            "EwoLdmVuZG9yX2NvZGUYCCABKAkSbgoPaW5pdGlhbF9iYWxhbmNlGAkgAygL",
            "MlUuV1VQcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuQWRtaW5HZXRJbkFw",
            "cFB1cmNoYXNlTG9nc1Jlc3BvbnNlLkJhbGFuY2VTbmFwc2hvdEVudHJ5EmwK",
            "DWZpbmFsX2JhbGFuY2UYCiADKAsyVS5XVVByb3Rvcy5OZXR3b3JraW5nLlJl",
            "c3BvbnNlcy5BZG1pbkdldEluQXBwUHVyY2hhc2VMb2dzUmVzcG9uc2UuQmFs",
            "YW5jZVNuYXBzaG90RW50cnkSDwoHaXRlbV9pZBgLIAMoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse), global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Parser, new[]{ "Log", "CurrentBalance" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry), global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry.Parser, new[]{ "CurrencyType", "Quantity" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog), global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog.Parser, new[]{ "TimestampMs", "PlayerId", "Type", "Description", "SkuId", "CurrencyUsed", "PricePaidE6", "VendorCode", "InitialBalance", "FinalBalance", "ItemId" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AdminGetInAppPurchaseLogsResponse : pb::IMessage<AdminGetInAppPurchaseLogsResponse> {
    private static readonly pb::MessageParser<AdminGetInAppPurchaseLogsResponse> _parser = new pb::MessageParser<AdminGetInAppPurchaseLogsResponse>(() => new AdminGetInAppPurchaseLogsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdminGetInAppPurchaseLogsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminGetInAppPurchaseLogsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminGetInAppPurchaseLogsResponse(AdminGetInAppPurchaseLogsResponse other) : this() {
      log_ = other.log_.Clone();
      currentBalance_ = other.currentBalance_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdminGetInAppPurchaseLogsResponse Clone() {
      return new AdminGetInAppPurchaseLogsResponse(this);
    }

    /// <summary>Field number for the "log" field.</summary>
    public const int LogFieldNumber = 1;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog> _repeated_log_codec
        = pb::FieldCodec.ForMessage(10, global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog> log_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.PlayerInAppPurchaseLog> Log {
      get { return log_; }
    }

    /// <summary>Field number for the "current_balance" field.</summary>
    public const int CurrentBalanceFieldNumber = 2;
    private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> _repeated_currentBalance_codec
        = pb::FieldCodec.ForMessage(18, global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry.Parser);
    private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> currentBalance_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> CurrentBalance {
      get { return currentBalance_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdminGetInAppPurchaseLogsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdminGetInAppPurchaseLogsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!log_.Equals(other.log_)) return false;
      if(!currentBalance_.Equals(other.currentBalance_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= log_.GetHashCode();
      hash ^= currentBalance_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      log_.WriteTo(output, _repeated_log_codec);
      currentBalance_.WriteTo(output, _repeated_currentBalance_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += log_.CalculateSize(_repeated_log_codec);
      size += currentBalance_.CalculateSize(_repeated_currentBalance_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdminGetInAppPurchaseLogsResponse other) {
      if (other == null) {
        return;
      }
      log_.Add(other.log_);
      currentBalance_.Add(other.currentBalance_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            log_.AddEntriesFrom(input, _repeated_log_codec);
            break;
          }
          case 18: {
            currentBalance_.AddEntriesFrom(input, _repeated_currentBalance_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AdminGetInAppPurchaseLogsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class BalanceSnapshotEntry : pb::IMessage<BalanceSnapshotEntry> {
        private static readonly pb::MessageParser<BalanceSnapshotEntry> _parser = new pb::MessageParser<BalanceSnapshotEntry>(() => new BalanceSnapshotEntry());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<BalanceSnapshotEntry> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BalanceSnapshotEntry() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BalanceSnapshotEntry(BalanceSnapshotEntry other) : this() {
          currencyType_ = other.currencyType_;
          quantity_ = other.quantity_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public BalanceSnapshotEntry Clone() {
          return new BalanceSnapshotEntry(this);
        }

        /// <summary>Field number for the "currency_type" field.</summary>
        public const int CurrencyTypeFieldNumber = 1;
        private string currencyType_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CurrencyType {
          get { return currencyType_; }
          set {
            currencyType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "quantity" field.</summary>
        public const int QuantityFieldNumber = 2;
        private int quantity_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Quantity {
          get { return quantity_; }
          set {
            quantity_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as BalanceSnapshotEntry);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(BalanceSnapshotEntry other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (CurrencyType != other.CurrencyType) return false;
          if (Quantity != other.Quantity) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (CurrencyType.Length != 0) hash ^= CurrencyType.GetHashCode();
          if (Quantity != 0) hash ^= Quantity.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (CurrencyType.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(CurrencyType);
          }
          if (Quantity != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Quantity);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (CurrencyType.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyType);
          }
          if (Quantity != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(BalanceSnapshotEntry other) {
          if (other == null) {
            return;
          }
          if (other.CurrencyType.Length != 0) {
            CurrencyType = other.CurrencyType;
          }
          if (other.Quantity != 0) {
            Quantity = other.Quantity;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                CurrencyType = input.ReadString();
                break;
              }
              case 16: {
                Quantity = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class PlayerInAppPurchaseLog : pb::IMessage<PlayerInAppPurchaseLog> {
        private static readonly pb::MessageParser<PlayerInAppPurchaseLog> _parser = new pb::MessageParser<PlayerInAppPurchaseLog>(() => new PlayerInAppPurchaseLog());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PlayerInAppPurchaseLog> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerInAppPurchaseLog() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerInAppPurchaseLog(PlayerInAppPurchaseLog other) : this() {
          timestampMs_ = other.timestampMs_;
          playerId_ = other.playerId_;
          type_ = other.type_;
          description_ = other.description_;
          skuId_ = other.skuId_;
          currencyUsed_ = other.currencyUsed_;
          pricePaidE6_ = other.pricePaidE6_;
          vendorCode_ = other.vendorCode_;
          initialBalance_ = other.initialBalance_.Clone();
          finalBalance_ = other.finalBalance_.Clone();
          itemId_ = other.itemId_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerInAppPurchaseLog Clone() {
          return new PlayerInAppPurchaseLog(this);
        }

        /// <summary>Field number for the "timestamp_ms" field.</summary>
        public const int TimestampMsFieldNumber = 1;
        private long timestampMs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long TimestampMs {
          get { return timestampMs_; }
          set {
            timestampMs_ = value;
          }
        }

        /// <summary>Field number for the "player_id" field.</summary>
        public const int PlayerIdFieldNumber = 2;
        private string playerId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string PlayerId {
          get { return playerId_; }
          set {
            playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 3;
        private string type_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Type {
          get { return type_; }
          set {
            type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "description" field.</summary>
        public const int DescriptionFieldNumber = 4;
        private string description_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Description {
          get { return description_; }
          set {
            description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "sku_id" field.</summary>
        public const int SkuIdFieldNumber = 5;
        private string skuId_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string SkuId {
          get { return skuId_; }
          set {
            skuId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "currency_used" field.</summary>
        public const int CurrencyUsedFieldNumber = 6;
        private string currencyUsed_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string CurrencyUsed {
          get { return currencyUsed_; }
          set {
            currencyUsed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "price_paid_e6" field.</summary>
        public const int PricePaidE6FieldNumber = 7;
        private long pricePaidE6_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long PricePaidE6 {
          get { return pricePaidE6_; }
          set {
            pricePaidE6_ = value;
          }
        }

        /// <summary>Field number for the "vendor_code" field.</summary>
        public const int VendorCodeFieldNumber = 8;
        private string vendorCode_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string VendorCode {
          get { return vendorCode_; }
          set {
            vendorCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "initial_balance" field.</summary>
        public const int InitialBalanceFieldNumber = 9;
        private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> _repeated_initialBalance_codec
            = pb::FieldCodec.ForMessage(74, global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry.Parser);
        private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> initialBalance_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> InitialBalance {
          get { return initialBalance_; }
        }

        /// <summary>Field number for the "final_balance" field.</summary>
        public const int FinalBalanceFieldNumber = 10;
        private static readonly pb::FieldCodec<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> _repeated_finalBalance_codec
            = pb::FieldCodec.ForMessage(82, global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry.Parser);
        private readonly pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> finalBalance_ = new pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::WUProtos.Networking.Responses.AdminGetInAppPurchaseLogsResponse.Types.BalanceSnapshotEntry> FinalBalance {
          get { return finalBalance_; }
        }

        /// <summary>Field number for the "item_id" field.</summary>
        public const int ItemIdFieldNumber = 11;
        private static readonly pb::FieldCodec<string> _repeated_itemId_codec
            = pb::FieldCodec.ForString(90);
        private readonly pbc::RepeatedField<string> itemId_ = new pbc::RepeatedField<string>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<string> ItemId {
          get { return itemId_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PlayerInAppPurchaseLog);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PlayerInAppPurchaseLog other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (TimestampMs != other.TimestampMs) return false;
          if (PlayerId != other.PlayerId) return false;
          if (Type != other.Type) return false;
          if (Description != other.Description) return false;
          if (SkuId != other.SkuId) return false;
          if (CurrencyUsed != other.CurrencyUsed) return false;
          if (PricePaidE6 != other.PricePaidE6) return false;
          if (VendorCode != other.VendorCode) return false;
          if(!initialBalance_.Equals(other.initialBalance_)) return false;
          if(!finalBalance_.Equals(other.finalBalance_)) return false;
          if(!itemId_.Equals(other.itemId_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (TimestampMs != 0L) hash ^= TimestampMs.GetHashCode();
          if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
          if (Type.Length != 0) hash ^= Type.GetHashCode();
          if (Description.Length != 0) hash ^= Description.GetHashCode();
          if (SkuId.Length != 0) hash ^= SkuId.GetHashCode();
          if (CurrencyUsed.Length != 0) hash ^= CurrencyUsed.GetHashCode();
          if (PricePaidE6 != 0L) hash ^= PricePaidE6.GetHashCode();
          if (VendorCode.Length != 0) hash ^= VendorCode.GetHashCode();
          hash ^= initialBalance_.GetHashCode();
          hash ^= finalBalance_.GetHashCode();
          hash ^= itemId_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (TimestampMs != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(TimestampMs);
          }
          if (PlayerId.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(PlayerId);
          }
          if (Type.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Type);
          }
          if (Description.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Description);
          }
          if (SkuId.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(SkuId);
          }
          if (CurrencyUsed.Length != 0) {
            output.WriteRawTag(50);
            output.WriteString(CurrencyUsed);
          }
          if (PricePaidE6 != 0L) {
            output.WriteRawTag(56);
            output.WriteInt64(PricePaidE6);
          }
          if (VendorCode.Length != 0) {
            output.WriteRawTag(66);
            output.WriteString(VendorCode);
          }
          initialBalance_.WriteTo(output, _repeated_initialBalance_codec);
          finalBalance_.WriteTo(output, _repeated_finalBalance_codec);
          itemId_.WriteTo(output, _repeated_itemId_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (TimestampMs != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimestampMs);
          }
          if (PlayerId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
          }
          if (Type.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
          }
          if (Description.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
          }
          if (SkuId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(SkuId);
          }
          if (CurrencyUsed.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyUsed);
          }
          if (PricePaidE6 != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(PricePaidE6);
          }
          if (VendorCode.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(VendorCode);
          }
          size += initialBalance_.CalculateSize(_repeated_initialBalance_codec);
          size += finalBalance_.CalculateSize(_repeated_finalBalance_codec);
          size += itemId_.CalculateSize(_repeated_itemId_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PlayerInAppPurchaseLog other) {
          if (other == null) {
            return;
          }
          if (other.TimestampMs != 0L) {
            TimestampMs = other.TimestampMs;
          }
          if (other.PlayerId.Length != 0) {
            PlayerId = other.PlayerId;
          }
          if (other.Type.Length != 0) {
            Type = other.Type;
          }
          if (other.Description.Length != 0) {
            Description = other.Description;
          }
          if (other.SkuId.Length != 0) {
            SkuId = other.SkuId;
          }
          if (other.CurrencyUsed.Length != 0) {
            CurrencyUsed = other.CurrencyUsed;
          }
          if (other.PricePaidE6 != 0L) {
            PricePaidE6 = other.PricePaidE6;
          }
          if (other.VendorCode.Length != 0) {
            VendorCode = other.VendorCode;
          }
          initialBalance_.Add(other.initialBalance_);
          finalBalance_.Add(other.finalBalance_);
          itemId_.Add(other.itemId_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 8: {
                TimestampMs = input.ReadInt64();
                break;
              }
              case 18: {
                PlayerId = input.ReadString();
                break;
              }
              case 26: {
                Type = input.ReadString();
                break;
              }
              case 34: {
                Description = input.ReadString();
                break;
              }
              case 42: {
                SkuId = input.ReadString();
                break;
              }
              case 50: {
                CurrencyUsed = input.ReadString();
                break;
              }
              case 56: {
                PricePaidE6 = input.ReadInt64();
                break;
              }
              case 66: {
                VendorCode = input.ReadString();
                break;
              }
              case 74: {
                initialBalance_.AddEntriesFrom(input, _repeated_initialBalance_codec);
                break;
              }
              case 82: {
                finalBalance_.AddEntriesFrom(input, _repeated_finalBalance_codec);
                break;
              }
              case 90: {
                itemId_.AddEntriesFrom(input, _repeated_itemId_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code

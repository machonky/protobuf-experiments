// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: DateTimeOffset.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ProtocolBufferExperiments.Common {

  /// <summary>Holder for reflection information generated from DateTimeOffset.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class DateTimeOffsetReflection {

    #region Descriptor
    /// <summary>File descriptor for DateTimeOffset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DateTimeOffsetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChREYXRlVGltZU9mZnNldC5wcm90bxIgUHJvdG9jb2xCdWZmZXJFeHBlcmlt",
            "ZW50cy5Db21tb24aDlRpbWVTcGFuLnByb3RvGg5EYXRlVGltZS5wcm90byKK",
            "AQoORGF0ZVRpbWVPZmZzZXQSPAoIRGF0ZVRpbWUYASABKAsyKi5Qcm90b2Nv",
            "bEJ1ZmZlckV4cGVyaW1lbnRzLkNvbW1vbi5EYXRlVGltZRI6CgZPZmZzZXQY",
            "AiABKAsyKi5Qcm90b2NvbEJ1ZmZlckV4cGVyaW1lbnRzLkNvbW1vbi5UaW1l",
            "U3BhbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::ProtocolBufferExperiments.Common.TimeSpanReflection.Descriptor, global::ProtocolBufferExperiments.Common.DateTimeReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::ProtocolBufferExperiments.Common.DateTimeOffset), global::ProtocolBufferExperiments.Common.DateTimeOffset.Parser, new[]{ "DateTime", "Offset" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class DateTimeOffset : pb::IMessage<DateTimeOffset> {
    private static readonly pb::MessageParser<DateTimeOffset> _parser = new pb::MessageParser<DateTimeOffset>(() => new DateTimeOffset());
    public static pb::MessageParser<DateTimeOffset> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::ProtocolBufferExperiments.Common.DateTimeOffsetReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public DateTimeOffset() {
      OnConstruction();
    }

    partial void OnConstruction();

    public DateTimeOffset(DateTimeOffset other) : this() {
      DateTime = other.dateTime_ != null ? other.DateTime.Clone() : null;
      Offset = other.offset_ != null ? other.Offset.Clone() : null;
    }

    public DateTimeOffset Clone() {
      return new DateTimeOffset(this);
    }

    /// <summary>Field number for the "DateTime" field.</summary>
    public const int DateTimeFieldNumber = 1;
    private global::ProtocolBufferExperiments.Common.DateTime dateTime_;
    public global::ProtocolBufferExperiments.Common.DateTime DateTime {
      get { return dateTime_; }
      set {
        dateTime_ = value;
      }
    }

    /// <summary>Field number for the "Offset" field.</summary>
    public const int OffsetFieldNumber = 2;
    private global::ProtocolBufferExperiments.Common.TimeSpan offset_;
    public global::ProtocolBufferExperiments.Common.TimeSpan Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as DateTimeOffset);
    }

    public bool Equals(DateTimeOffset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DateTime, other.DateTime)) return false;
      if (!object.Equals(Offset, other.Offset)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (dateTime_ != null) hash ^= DateTime.GetHashCode();
      if (offset_ != null) hash ^= Offset.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (dateTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DateTime);
      }
      if (offset_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Offset);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (dateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DateTime);
      }
      if (offset_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Offset);
      }
      return size;
    }

    public void MergeFrom(DateTimeOffset other) {
      if (other == null) {
        return;
      }
      if (other.dateTime_ != null) {
        if (dateTime_ == null) {
          dateTime_ = new global::ProtocolBufferExperiments.Common.DateTime();
        }
        DateTime.MergeFrom(other.DateTime);
      }
      if (other.offset_ != null) {
        if (offset_ == null) {
          offset_ = new global::ProtocolBufferExperiments.Common.TimeSpan();
        }
        Offset.MergeFrom(other.Offset);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (dateTime_ == null) {
              dateTime_ = new global::ProtocolBufferExperiments.Common.DateTime();
            }
            input.ReadMessage(dateTime_);
            break;
          }
          case 18: {
            if (offset_ == null) {
              offset_ = new global::ProtocolBufferExperiments.Common.TimeSpan();
            }
            input.ReadMessage(offset_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

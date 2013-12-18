//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_partnerapps.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_RequestUploadToken_Request")]
  public partial class CPartnerApps_RequestUploadToken_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_RequestUploadToken_Request() {}
    

    private string _filename = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filename", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string filename
    {
      get { return _filename; }
      set { _filename = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_RequestUploadToken_Response")]
  public partial class CPartnerApps_RequestUploadToken_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_RequestUploadToken_Response() {}
    

    private ulong _upload_token = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong upload_token
    {
      get { return _upload_token; }
      set { _upload_token = value; }
    }

    private string _location = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string location
    {
      get { return _location; }
      set { _location = value; }
    }

    private ulong _routing_id = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong routing_id
    {
      get { return _routing_id; }
      set { _routing_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUpload_Request")]
  public partial class CPartnerApps_FinishUpload_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUpload_Request() {}
    

    private ulong _upload_token = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong upload_token
    {
      get { return _upload_token; }
      set { _upload_token = value; }
    }

    private ulong _routing_id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong routing_id
    {
      get { return _routing_id; }
      set { _routing_id = value; }
    }

    private uint _app_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint app_id
    {
      get { return _app_id; }
      set { _app_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadKVSign_Response")]
  public partial class CPartnerApps_FinishUploadKVSign_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadKVSign_Response() {}
    

    private string _signed_installscript = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"signed_installscript", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string signed_installscript
    {
      get { return _signed_installscript; }
      set { _signed_installscript = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadLegacyDRM_Request")]
  public partial class CPartnerApps_FinishUploadLegacyDRM_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadLegacyDRM_Request() {}
    

    private ulong _upload_token = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"upload_token", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong upload_token
    {
      get { return _upload_token; }
      set { _upload_token = value; }
    }

    private ulong _routing_id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"routing_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong routing_id
    {
      get { return _routing_id; }
      set { _routing_id = value; }
    }

    private uint _app_id = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint app_id
    {
      get { return _app_id; }
      set { _app_id = value; }
    }

    private uint _flags = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint flags
    {
      get { return _flags; }
      set { _flags = value; }
    }

    private string _tool_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"tool_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tool_name
    {
      get { return _tool_name; }
      set { _tool_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUploadLegacyDRM_Response")]
  public partial class CPartnerApps_FinishUploadLegacyDRM_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUploadLegacyDRM_Response() {}
    

    private string _file_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_id
    {
      get { return _file_id; }
      set { _file_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FinishUpload_Response")]
  public partial class CPartnerApps_FinishUpload_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FinishUpload_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FindDRMUploads_Request")]
  public partial class CPartnerApps_FindDRMUploads_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FindDRMUploads_Request() {}
    

    private int _app_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int app_id
    {
      get { return _app_id; }
      set { _app_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_ExistingDRMUpload")]
  public partial class CPartnerApps_ExistingDRMUpload : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_ExistingDRMUpload() {}
    

    private string _file_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_id
    {
      get { return _file_id; }
      set { _file_id = value; }
    }

    private uint _app_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint app_id
    {
      get { return _app_id; }
      set { _app_id = value; }
    }

    private int _actor_id = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"actor_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int actor_id
    {
      get { return _actor_id; }
      set { _actor_id = value; }
    }

    private string _supplied_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"supplied_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string supplied_name
    {
      get { return _supplied_name; }
      set { _supplied_name = value; }
    }

    private uint _flags = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"flags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint flags
    {
      get { return _flags; }
      set { _flags = value; }
    }

    private string _mod_type = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"mod_type", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string mod_type
    {
      get { return _mod_type; }
      set { _mod_type = value; }
    }

    private uint _timestamp = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }

    private string _orig_file_id = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"orig_file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string orig_file_id
    {
      get { return _orig_file_id; }
      set { _orig_file_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_FindDRMUploads_Response")]
  public partial class CPartnerApps_FindDRMUploads_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_FindDRMUploads_Response() {}
    
    private readonly global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload> _uploads = new global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload>();
    [global::ProtoBuf.ProtoMember(1, Name=@"uploads", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPartnerApps_ExistingDRMUpload> uploads
    {
      get { return _uploads; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_Download_Request")]
  public partial class CPartnerApps_Download_Request : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_Download_Request() {}
    

    private string _file_id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"file_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_id
    {
      get { return _file_id; }
      set { _file_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPartnerApps_Download_Response")]
  public partial class CPartnerApps_Download_Response : global::ProtoBuf.IExtensible
  {
    public CPartnerApps_Download_Response() {}
    

    private string _download_url = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"download_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string download_url
    {
      get { return _download_url; }
      set { _download_url = value; }
    }

    private int _app_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"app_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int app_id
    {
      get { return _app_id; }
      set { _app_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPartnerApps
    {
      CPartnerApps_RequestUploadToken_Response RequestKVSignUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_RequestUploadToken_Response RequestDRMUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_RequestUploadToken_Response RequestCEGUploadToken(CPartnerApps_RequestUploadToken_Request request);
    CPartnerApps_FinishUploadKVSign_Response FinishUploadKVSign(CPartnerApps_FinishUpload_Request request);
    CPartnerApps_FinishUploadLegacyDRM_Response FinishUploadDRMUpload(CPartnerApps_FinishUploadLegacyDRM_Request request);
    CPartnerApps_FinishUpload_Response FinishUploadCEGUpload(CPartnerApps_FinishUpload_Request request);
    CPartnerApps_FindDRMUploads_Response FindDRMUploads(CPartnerApps_FindDRMUploads_Request request);
    CPartnerApps_Download_Response Download(CPartnerApps_Download_Request request);
    
    }
    
    
}
#pragma warning restore 1591

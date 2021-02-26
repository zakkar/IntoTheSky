using UnityEngine.Events;

namespace UnityEvents
{
    [System.Serializable]
    public class FEvent : UnityEvent<float> { }

    [System.Serializable]
    public class IEvent : UnityEvent<int> { }

    [System.Serializable]
    public class SEvent : UnityEvent<string> { }

    [System.Serializable]
    public class BEvent : UnityEvent<bool> { }

    [System.Serializable]
    public class OEvent : UnityEvent<object> { }

    [System.Serializable]
    public class FFEvent : UnityEvent<float, float> { }

    [System.Serializable]
    public class FIEvent : UnityEvent<float, int> { }

    [System.Serializable]
    public class FSEvent : UnityEvent<float, string> { }

    [System.Serializable]
    public class FBEvent : UnityEvent<float, bool> { }

    [System.Serializable]
    public class FOEvent : UnityEvent<float, object> { }

    [System.Serializable]
    public class IFEvent : UnityEvent<int, float> { }

    [System.Serializable]
    public class IIEvent : UnityEvent<int, int> { }

    [System.Serializable]
    public class ISEvent : UnityEvent<int, string> { }

    [System.Serializable]
    public class IBEvent : UnityEvent<int, bool> { }

    [System.Serializable]
    public class IOEvent : UnityEvent<int, object> { }

    [System.Serializable]
    public class SFEvent : UnityEvent<string, float> { }

    [System.Serializable]
    public class SIEvent : UnityEvent<string, int> { }

    [System.Serializable]
    public class SSEvent : UnityEvent<string, string> { }

    [System.Serializable]
    public class SBEvent : UnityEvent<string, bool> { }

    [System.Serializable]
    public class SOEvent : UnityEvent<string, object> { }

    [System.Serializable]
    public class BFEvent : UnityEvent<bool, float> { }

    [System.Serializable]
    public class BIEvent : UnityEvent<bool, int> { }

    [System.Serializable]
    public class BSEvent : UnityEvent<bool, string> { }

    [System.Serializable]
    public class BBEvent : UnityEvent<bool, bool> { }

    [System.Serializable]
    public class BOEvent : UnityEvent<bool, object> { }

    [System.Serializable]
    public class OFEvent : UnityEvent<object, float> { }

    [System.Serializable]
    public class OIEvent : UnityEvent<object, int> { }

    [System.Serializable]
    public class OSEvent : UnityEvent<object, string> { }

    [System.Serializable]
    public class OBEvent : UnityEvent<object, bool> { }

    [System.Serializable]
    public class OOEvent : UnityEvent<object, object> { }

    [System.Serializable]
    public class FFFEvent : UnityEvent<float, float, float> { }

    [System.Serializable]
    public class FFIEvent : UnityEvent<float, float, int> { }

    [System.Serializable]
    public class FFSEvent : UnityEvent<float, float, string> { }

    [System.Serializable]
    public class FFBEvent : UnityEvent<float, float, bool> { }

    [System.Serializable]
    public class FFOEvent : UnityEvent<float, float, object> { }

    [System.Serializable]
    public class FIFEvent : UnityEvent<float, int, float> { }

    [System.Serializable]
    public class FIIEvent : UnityEvent<float, int, int> { }

    [System.Serializable]
    public class FISEvent : UnityEvent<float, int, string> { }

    [System.Serializable]
    public class FIBEvent : UnityEvent<float, int, bool> { }

    [System.Serializable]
    public class FIOEvent : UnityEvent<float, int, object> { }

    [System.Serializable]
    public class FSFEvent : UnityEvent<float, string, float> { }

    [System.Serializable]
    public class FSIEvent : UnityEvent<float, string, int> { }

    [System.Serializable]
    public class FSSEvent : UnityEvent<float, string, string> { }

    [System.Serializable]
    public class FSBEvent : UnityEvent<float, string, bool> { }

    [System.Serializable]
    public class FSOEvent : UnityEvent<float, string, object> { }

    [System.Serializable]
    public class FBFEvent : UnityEvent<float, bool, float> { }

    [System.Serializable]
    public class FBIEvent : UnityEvent<float, bool, int> { }

    [System.Serializable]
    public class FBSEvent : UnityEvent<float, bool, string> { }

    [System.Serializable]
    public class FBBEvent : UnityEvent<float, bool, bool> { }

    [System.Serializable]
    public class FBOEvent : UnityEvent<float, bool, object> { }

    [System.Serializable]
    public class FOFEvent : UnityEvent<float, object, float> { }

    [System.Serializable]
    public class FOIEvent : UnityEvent<float, object, int> { }

    [System.Serializable]
    public class FOSEvent : UnityEvent<float, object, string> { }

    [System.Serializable]
    public class FOBEvent : UnityEvent<float, object, bool> { }

    [System.Serializable]
    public class FOOEvent : UnityEvent<float, object, object> { }

    [System.Serializable]
    public class IFFEvent : UnityEvent<int, float, float> { }

    [System.Serializable]
    public class IFIEvent : UnityEvent<int, float, int> { }

    [System.Serializable]
    public class IFSEvent : UnityEvent<int, float, string> { }

    [System.Serializable]
    public class IFBEvent : UnityEvent<int, float, bool> { }

    [System.Serializable]
    public class IFOEvent : UnityEvent<int, float, object> { }

    [System.Serializable]
    public class IIFEvent : UnityEvent<int, int, float> { }

    [System.Serializable]
    public class IIIEvent : UnityEvent<int, int, int> { }

    [System.Serializable]
    public class IISEvent : UnityEvent<int, int, string> { }

    [System.Serializable]
    public class IIBEvent : UnityEvent<int, int, bool> { }

    [System.Serializable]
    public class IIOEvent : UnityEvent<int, int, object> { }

    [System.Serializable]
    public class ISFEvent : UnityEvent<int, string, float> { }

    [System.Serializable]
    public class ISIEvent : UnityEvent<int, string, int> { }

    [System.Serializable]
    public class ISSEvent : UnityEvent<int, string, string> { }

    [System.Serializable]
    public class ISBEvent : UnityEvent<int, string, bool> { }

    [System.Serializable]
    public class ISOEvent : UnityEvent<int, string, object> { }

    [System.Serializable]
    public class IBFEvent : UnityEvent<int, bool, float> { }

    [System.Serializable]
    public class IBIEvent : UnityEvent<int, bool, int> { }

    [System.Serializable]
    public class IBSEvent : UnityEvent<int, bool, string> { }

    [System.Serializable]
    public class IBBEvent : UnityEvent<int, bool, bool> { }

    [System.Serializable]
    public class IBOEvent : UnityEvent<int, bool, object> { }

    [System.Serializable]
    public class IOFEvent : UnityEvent<int, object, float> { }

    [System.Serializable]
    public class IOIEvent : UnityEvent<int, object, int> { }

    [System.Serializable]
    public class IOSEvent : UnityEvent<int, object, string> { }

    [System.Serializable]
    public class IOBEvent : UnityEvent<int, object, bool> { }

    [System.Serializable]
    public class IOOEvent : UnityEvent<int, object, object> { }

    [System.Serializable]
    public class SFFEvent : UnityEvent<string, float, float> { }

    [System.Serializable]
    public class SFIEvent : UnityEvent<string, float, int> { }

    [System.Serializable]
    public class SFSEvent : UnityEvent<string, float, string> { }

    [System.Serializable]
    public class SFBEvent : UnityEvent<string, float, bool> { }

    [System.Serializable]
    public class SFOEvent : UnityEvent<string, float, object> { }

    [System.Serializable]
    public class SIFEvent : UnityEvent<string, int, float> { }

    [System.Serializable]
    public class SIIEvent : UnityEvent<string, int, int> { }

    [System.Serializable]
    public class SISEvent : UnityEvent<string, int, string> { }

    [System.Serializable]
    public class SIBEvent : UnityEvent<string, int, bool> { }

    [System.Serializable]
    public class SIOEvent : UnityEvent<string, int, object> { }

    [System.Serializable]
    public class SSFEvent : UnityEvent<string, string, float> { }

    [System.Serializable]
    public class SSIEvent : UnityEvent<string, string, int> { }

    [System.Serializable]
    public class SSSEvent : UnityEvent<string, string, string> { }

    [System.Serializable]
    public class SSBEvent : UnityEvent<string, string, bool> { }

    [System.Serializable]
    public class SSOEvent : UnityEvent<string, string, object> { }

    [System.Serializable]
    public class SBFEvent : UnityEvent<string, bool, float> { }

    [System.Serializable]
    public class SBIEvent : UnityEvent<string, bool, int> { }

    [System.Serializable]
    public class SBSEvent : UnityEvent<string, bool, string> { }

    [System.Serializable]
    public class SBBEvent : UnityEvent<string, bool, bool> { }

    [System.Serializable]
    public class SBOEvent : UnityEvent<string, bool, object> { }

    [System.Serializable]
    public class SOFEvent : UnityEvent<string, object, float> { }

    [System.Serializable]
    public class SOIEvent : UnityEvent<string, object, int> { }

    [System.Serializable]
    public class SOSEvent : UnityEvent<string, object, string> { }

    [System.Serializable]
    public class SOBEvent : UnityEvent<string, object, bool> { }

    [System.Serializable]
    public class SOOEvent : UnityEvent<string, object, object> { }

    [System.Serializable]
    public class BFFEvent : UnityEvent<bool, float, float> { }

    [System.Serializable]
    public class BFIEvent : UnityEvent<bool, float, int> { }

    [System.Serializable]
    public class BFSEvent : UnityEvent<bool, float, string> { }

    [System.Serializable]
    public class BFBEvent : UnityEvent<bool, float, bool> { }

    [System.Serializable]
    public class BFOEvent : UnityEvent<bool, float, object> { }

    [System.Serializable]
    public class BIFEvent : UnityEvent<bool, int, float> { }

    [System.Serializable]
    public class BIIEvent : UnityEvent<bool, int, int> { }

    [System.Serializable]
    public class BISEvent : UnityEvent<bool, int, string> { }

    [System.Serializable]
    public class BIBEvent : UnityEvent<bool, int, bool> { }

    [System.Serializable]
    public class BIOEvent : UnityEvent<bool, int, object> { }

    [System.Serializable]
    public class BSFEvent : UnityEvent<bool, string, float> { }

    [System.Serializable]
    public class BSIEvent : UnityEvent<bool, string, int> { }

    [System.Serializable]
    public class BSSEvent : UnityEvent<bool, string, string> { }

    [System.Serializable]
    public class BSBEvent : UnityEvent<bool, string, bool> { }

    [System.Serializable]
    public class BSOEvent : UnityEvent<bool, string, object> { }

    [System.Serializable]
    public class BBFEvent : UnityEvent<bool, bool, float> { }

    [System.Serializable]
    public class BBIEvent : UnityEvent<bool, bool, int> { }

    [System.Serializable]
    public class BBSEvent : UnityEvent<bool, bool, string> { }

    [System.Serializable]
    public class BBBEvent : UnityEvent<bool, bool, bool> { }

    [System.Serializable]
    public class BBOEvent : UnityEvent<bool, bool, object> { }

    [System.Serializable]
    public class BOFEvent : UnityEvent<bool, object, float> { }

    [System.Serializable]
    public class BOIEvent : UnityEvent<bool, object, int> { }

    [System.Serializable]
    public class BOSEvent : UnityEvent<bool, object, string> { }

    [System.Serializable]
    public class BOBEvent : UnityEvent<bool, object, bool> { }

    [System.Serializable]
    public class BOOEvent : UnityEvent<bool, object, object> { }

    [System.Serializable]
    public class OFFEvent : UnityEvent<object, float, float> { }

    [System.Serializable]
    public class OFIEvent : UnityEvent<object, float, int> { }

    [System.Serializable]
    public class OFSEvent : UnityEvent<object, float, string> { }

    [System.Serializable]
    public class OFBEvent : UnityEvent<object, float, bool> { }

    [System.Serializable]
    public class OFOEvent : UnityEvent<object, float, object> { }

    [System.Serializable]
    public class OIFEvent : UnityEvent<object, int, float> { }

    [System.Serializable]
    public class OIIEvent : UnityEvent<object, int, int> { }

    [System.Serializable]
    public class OISEvent : UnityEvent<object, int, string> { }

    [System.Serializable]
    public class OIBEvent : UnityEvent<object, int, bool> { }

    [System.Serializable]
    public class OIOEvent : UnityEvent<object, int, object> { }

    [System.Serializable]
    public class OSFEvent : UnityEvent<object, string, float> { }

    [System.Serializable]
    public class OSIEvent : UnityEvent<object, string, int> { }

    [System.Serializable]
    public class OSSEvent : UnityEvent<object, string, string> { }

    [System.Serializable]
    public class OSBEvent : UnityEvent<object, string, bool> { }

    [System.Serializable]
    public class OSOEvent : UnityEvent<object, string, object> { }

    [System.Serializable]
    public class OBFEvent : UnityEvent<object, bool, float> { }

    [System.Serializable]
    public class OBIEvent : UnityEvent<object, bool, int> { }

    [System.Serializable]
    public class OBSEvent : UnityEvent<object, bool, string> { }

    [System.Serializable]
    public class OBBEvent : UnityEvent<object, bool, bool> { }

    [System.Serializable]
    public class OBOEvent : UnityEvent<object, bool, object> { }

    [System.Serializable]
    public class OOFEvent : UnityEvent<object, object, float> { }

    [System.Serializable]
    public class OOIEvent : UnityEvent<object, object, int> { }

    [System.Serializable]
    public class OOSEvent : UnityEvent<object, object, string> { }

    [System.Serializable]
    public class OOBEvent : UnityEvent<object, object, bool> { }

    [System.Serializable]
    public class OOOEvent : UnityEvent<object, object, object> { }

    [System.Serializable]
    public class FFFFEvent : UnityEvent<float, float, float, float> { }

    [System.Serializable]
    public class FFFIEvent : UnityEvent<float, float, float, int> { }

    [System.Serializable]
    public class FFFSEvent : UnityEvent<float, float, float, string> { }

    [System.Serializable]
    public class FFFBEvent : UnityEvent<float, float, float, bool> { }

    [System.Serializable]
    public class FFFOEvent : UnityEvent<float, float, float, object> { }

    [System.Serializable]
    public class FFIFEvent : UnityEvent<float, float, int, float> { }

    [System.Serializable]
    public class FFIIEvent : UnityEvent<float, float, int, int> { }

    [System.Serializable]
    public class FFISEvent : UnityEvent<float, float, int, string> { }

    [System.Serializable]
    public class FFIBEvent : UnityEvent<float, float, int, bool> { }

    [System.Serializable]
    public class FFIOEvent : UnityEvent<float, float, int, object> { }

    [System.Serializable]
    public class FFSFEvent : UnityEvent<float, float, string, float> { }

    [System.Serializable]
    public class FFSIEvent : UnityEvent<float, float, string, int> { }

    [System.Serializable]
    public class FFSSEvent : UnityEvent<float, float, string, string> { }

    [System.Serializable]
    public class FFSBEvent : UnityEvent<float, float, string, bool> { }

    [System.Serializable]
    public class FFSOEvent : UnityEvent<float, float, string, object> { }

    [System.Serializable]
    public class FFBFEvent : UnityEvent<float, float, bool, float> { }

    [System.Serializable]
    public class FFBIEvent : UnityEvent<float, float, bool, int> { }

    [System.Serializable]
    public class FFBSEvent : UnityEvent<float, float, bool, string> { }

    [System.Serializable]
    public class FFBBEvent : UnityEvent<float, float, bool, bool> { }

    [System.Serializable]
    public class FFBOEvent : UnityEvent<float, float, bool, object> { }

    [System.Serializable]
    public class FFOFEvent : UnityEvent<float, float, object, float> { }

    [System.Serializable]
    public class FFOIEvent : UnityEvent<float, float, object, int> { }

    [System.Serializable]
    public class FFOSEvent : UnityEvent<float, float, object, string> { }

    [System.Serializable]
    public class FFOBEvent : UnityEvent<float, float, object, bool> { }

    [System.Serializable]
    public class FFOOEvent : UnityEvent<float, float, object, object> { }

    [System.Serializable]
    public class FIFFEvent : UnityEvent<float, int, float, float> { }

    [System.Serializable]
    public class FIFIEvent : UnityEvent<float, int, float, int> { }

    [System.Serializable]
    public class FIFSEvent : UnityEvent<float, int, float, string> { }

    [System.Serializable]
    public class FIFBEvent : UnityEvent<float, int, float, bool> { }

    [System.Serializable]
    public class FIFOEvent : UnityEvent<float, int, float, object> { }

    [System.Serializable]
    public class FIIFEvent : UnityEvent<float, int, int, float> { }

    [System.Serializable]
    public class FIIIEvent : UnityEvent<float, int, int, int> { }

    [System.Serializable]
    public class FIISEvent : UnityEvent<float, int, int, string> { }

    [System.Serializable]
    public class FIIBEvent : UnityEvent<float, int, int, bool> { }

    [System.Serializable]
    public class FIIOEvent : UnityEvent<float, int, int, object> { }

    [System.Serializable]
    public class FISFEvent : UnityEvent<float, int, string, float> { }

    [System.Serializable]
    public class FISIEvent : UnityEvent<float, int, string, int> { }

    [System.Serializable]
    public class FISSEvent : UnityEvent<float, int, string, string> { }

    [System.Serializable]
    public class FISBEvent : UnityEvent<float, int, string, bool> { }

    [System.Serializable]
    public class FISOEvent : UnityEvent<float, int, string, object> { }

    [System.Serializable]
    public class FIBFEvent : UnityEvent<float, int, bool, float> { }

    [System.Serializable]
    public class FIBIEvent : UnityEvent<float, int, bool, int> { }

    [System.Serializable]
    public class FIBSEvent : UnityEvent<float, int, bool, string> { }

    [System.Serializable]
    public class FIBBEvent : UnityEvent<float, int, bool, bool> { }

    [System.Serializable]
    public class FIBOEvent : UnityEvent<float, int, bool, object> { }

    [System.Serializable]
    public class FIOFEvent : UnityEvent<float, int, object, float> { }

    [System.Serializable]
    public class FIOIEvent : UnityEvent<float, int, object, int> { }

    [System.Serializable]
    public class FIOSEvent : UnityEvent<float, int, object, string> { }

    [System.Serializable]
    public class FIOBEvent : UnityEvent<float, int, object, bool> { }

    [System.Serializable]
    public class FIOOEvent : UnityEvent<float, int, object, object> { }

    [System.Serializable]
    public class FSFFEvent : UnityEvent<float, string, float, float> { }

    [System.Serializable]
    public class FSFIEvent : UnityEvent<float, string, float, int> { }

    [System.Serializable]
    public class FSFSEvent : UnityEvent<float, string, float, string> { }

    [System.Serializable]
    public class FSFBEvent : UnityEvent<float, string, float, bool> { }

    [System.Serializable]
    public class FSFOEvent : UnityEvent<float, string, float, object> { }

    [System.Serializable]
    public class FSIFEvent : UnityEvent<float, string, int, float> { }

    [System.Serializable]
    public class FSIIEvent : UnityEvent<float, string, int, int> { }

    [System.Serializable]
    public class FSISEvent : UnityEvent<float, string, int, string> { }

    [System.Serializable]
    public class FSIBEvent : UnityEvent<float, string, int, bool> { }

    [System.Serializable]
    public class FSIOEvent : UnityEvent<float, string, int, object> { }

    [System.Serializable]
    public class FSSFEvent : UnityEvent<float, string, string, float> { }

    [System.Serializable]
    public class FSSIEvent : UnityEvent<float, string, string, int> { }

    [System.Serializable]
    public class FSSSEvent : UnityEvent<float, string, string, string> { }

    [System.Serializable]
    public class FSSBEvent : UnityEvent<float, string, string, bool> { }

    [System.Serializable]
    public class FSSOEvent : UnityEvent<float, string, string, object> { }

    [System.Serializable]
    public class FSBFEvent : UnityEvent<float, string, bool, float> { }

    [System.Serializable]
    public class FSBIEvent : UnityEvent<float, string, bool, int> { }

    [System.Serializable]
    public class FSBSEvent : UnityEvent<float, string, bool, string> { }

    [System.Serializable]
    public class FSBBEvent : UnityEvent<float, string, bool, bool> { }

    [System.Serializable]
    public class FSBOEvent : UnityEvent<float, string, bool, object> { }

    [System.Serializable]
    public class FSOFEvent : UnityEvent<float, string, object, float> { }

    [System.Serializable]
    public class FSOIEvent : UnityEvent<float, string, object, int> { }

    [System.Serializable]
    public class FSOSEvent : UnityEvent<float, string, object, string> { }

    [System.Serializable]
    public class FSOBEvent : UnityEvent<float, string, object, bool> { }

    [System.Serializable]
    public class FSOOEvent : UnityEvent<float, string, object, object> { }

    [System.Serializable]
    public class FBFFEvent : UnityEvent<float, bool, float, float> { }

    [System.Serializable]
    public class FBFIEvent : UnityEvent<float, bool, float, int> { }

    [System.Serializable]
    public class FBFSEvent : UnityEvent<float, bool, float, string> { }

    [System.Serializable]
    public class FBFBEvent : UnityEvent<float, bool, float, bool> { }

    [System.Serializable]
    public class FBFOEvent : UnityEvent<float, bool, float, object> { }

    [System.Serializable]
    public class FBIFEvent : UnityEvent<float, bool, int, float> { }

    [System.Serializable]
    public class FBIIEvent : UnityEvent<float, bool, int, int> { }

    [System.Serializable]
    public class FBISEvent : UnityEvent<float, bool, int, string> { }

    [System.Serializable]
    public class FBIBEvent : UnityEvent<float, bool, int, bool> { }

    [System.Serializable]
    public class FBIOEvent : UnityEvent<float, bool, int, object> { }

    [System.Serializable]
    public class FBSFEvent : UnityEvent<float, bool, string, float> { }

    [System.Serializable]
    public class FBSIEvent : UnityEvent<float, bool, string, int> { }

    [System.Serializable]
    public class FBSSEvent : UnityEvent<float, bool, string, string> { }

    [System.Serializable]
    public class FBSBEvent : UnityEvent<float, bool, string, bool> { }

    [System.Serializable]
    public class FBSOEvent : UnityEvent<float, bool, string, object> { }

    [System.Serializable]
    public class FBBFEvent : UnityEvent<float, bool, bool, float> { }

    [System.Serializable]
    public class FBBIEvent : UnityEvent<float, bool, bool, int> { }

    [System.Serializable]
    public class FBBSEvent : UnityEvent<float, bool, bool, string> { }

    [System.Serializable]
    public class FBBBEvent : UnityEvent<float, bool, bool, bool> { }

    [System.Serializable]
    public class FBBOEvent : UnityEvent<float, bool, bool, object> { }

    [System.Serializable]
    public class FBOFEvent : UnityEvent<float, bool, object, float> { }

    [System.Serializable]
    public class FBOIEvent : UnityEvent<float, bool, object, int> { }

    [System.Serializable]
    public class FBOSEvent : UnityEvent<float, bool, object, string> { }

    [System.Serializable]
    public class FBOBEvent : UnityEvent<float, bool, object, bool> { }

    [System.Serializable]
    public class FBOOEvent : UnityEvent<float, bool, object, object> { }

    [System.Serializable]
    public class FOFFEvent : UnityEvent<float, object, float, float> { }

    [System.Serializable]
    public class FOFIEvent : UnityEvent<float, object, float, int> { }

    [System.Serializable]
    public class FOFSEvent : UnityEvent<float, object, float, string> { }

    [System.Serializable]
    public class FOFBEvent : UnityEvent<float, object, float, bool> { }

    [System.Serializable]
    public class FOFOEvent : UnityEvent<float, object, float, object> { }

    [System.Serializable]
    public class FOIFEvent : UnityEvent<float, object, int, float> { }

    [System.Serializable]
    public class FOIIEvent : UnityEvent<float, object, int, int> { }

    [System.Serializable]
    public class FOISEvent : UnityEvent<float, object, int, string> { }

    [System.Serializable]
    public class FOIBEvent : UnityEvent<float, object, int, bool> { }

    [System.Serializable]
    public class FOIOEvent : UnityEvent<float, object, int, object> { }

    [System.Serializable]
    public class FOSFEvent : UnityEvent<float, object, string, float> { }

    [System.Serializable]
    public class FOSIEvent : UnityEvent<float, object, string, int> { }

    [System.Serializable]
    public class FOSSEvent : UnityEvent<float, object, string, string> { }

    [System.Serializable]
    public class FOSBEvent : UnityEvent<float, object, string, bool> { }

    [System.Serializable]
    public class FOSOEvent : UnityEvent<float, object, string, object> { }

    [System.Serializable]
    public class FOBFEvent : UnityEvent<float, object, bool, float> { }

    [System.Serializable]
    public class FOBIEvent : UnityEvent<float, object, bool, int> { }

    [System.Serializable]
    public class FOBSEvent : UnityEvent<float, object, bool, string> { }

    [System.Serializable]
    public class FOBBEvent : UnityEvent<float, object, bool, bool> { }

    [System.Serializable]
    public class FOBOEvent : UnityEvent<float, object, bool, object> { }

    [System.Serializable]
    public class FOOFEvent : UnityEvent<float, object, object, float> { }

    [System.Serializable]
    public class FOOIEvent : UnityEvent<float, object, object, int> { }

    [System.Serializable]
    public class FOOSEvent : UnityEvent<float, object, object, string> { }

    [System.Serializable]
    public class FOOBEvent : UnityEvent<float, object, object, bool> { }

    [System.Serializable]
    public class FOOOEvent : UnityEvent<float, object, object, object> { }

    [System.Serializable]
    public class IFFFEvent : UnityEvent<int, float, float, float> { }

    [System.Serializable]
    public class IFFIEvent : UnityEvent<int, float, float, int> { }

    [System.Serializable]
    public class IFFSEvent : UnityEvent<int, float, float, string> { }

    [System.Serializable]
    public class IFFBEvent : UnityEvent<int, float, float, bool> { }

    [System.Serializable]
    public class IFFOEvent : UnityEvent<int, float, float, object> { }

    [System.Serializable]
    public class IFIFEvent : UnityEvent<int, float, int, float> { }

    [System.Serializable]
    public class IFIIEvent : UnityEvent<int, float, int, int> { }

    [System.Serializable]
    public class IFISEvent : UnityEvent<int, float, int, string> { }

    [System.Serializable]
    public class IFIBEvent : UnityEvent<int, float, int, bool> { }

    [System.Serializable]
    public class IFIOEvent : UnityEvent<int, float, int, object> { }

    [System.Serializable]
    public class IFSFEvent : UnityEvent<int, float, string, float> { }

    [System.Serializable]
    public class IFSIEvent : UnityEvent<int, float, string, int> { }

    [System.Serializable]
    public class IFSSEvent : UnityEvent<int, float, string, string> { }

    [System.Serializable]
    public class IFSBEvent : UnityEvent<int, float, string, bool> { }

    [System.Serializable]
    public class IFSOEvent : UnityEvent<int, float, string, object> { }

    [System.Serializable]
    public class IFBFEvent : UnityEvent<int, float, bool, float> { }

    [System.Serializable]
    public class IFBIEvent : UnityEvent<int, float, bool, int> { }

    [System.Serializable]
    public class IFBSEvent : UnityEvent<int, float, bool, string> { }

    [System.Serializable]
    public class IFBBEvent : UnityEvent<int, float, bool, bool> { }

    [System.Serializable]
    public class IFBOEvent : UnityEvent<int, float, bool, object> { }

    [System.Serializable]
    public class IFOFEvent : UnityEvent<int, float, object, float> { }

    [System.Serializable]
    public class IFOIEvent : UnityEvent<int, float, object, int> { }

    [System.Serializable]
    public class IFOSEvent : UnityEvent<int, float, object, string> { }

    [System.Serializable]
    public class IFOBEvent : UnityEvent<int, float, object, bool> { }

    [System.Serializable]
    public class IFOOEvent : UnityEvent<int, float, object, object> { }

    [System.Serializable]
    public class IIFFEvent : UnityEvent<int, int, float, float> { }

    [System.Serializable]
    public class IIFIEvent : UnityEvent<int, int, float, int> { }

    [System.Serializable]
    public class IIFSEvent : UnityEvent<int, int, float, string> { }

    [System.Serializable]
    public class IIFBEvent : UnityEvent<int, int, float, bool> { }

    [System.Serializable]
    public class IIFOEvent : UnityEvent<int, int, float, object> { }

    [System.Serializable]
    public class IIIFEvent : UnityEvent<int, int, int, float> { }

    [System.Serializable]
    public class IIIIEvent : UnityEvent<int, int, int, int> { }

    [System.Serializable]
    public class IIISEvent : UnityEvent<int, int, int, string> { }

    [System.Serializable]
    public class IIIBEvent : UnityEvent<int, int, int, bool> { }

    [System.Serializable]
    public class IIIOEvent : UnityEvent<int, int, int, object> { }

    [System.Serializable]
    public class IISFEvent : UnityEvent<int, int, string, float> { }

    [System.Serializable]
    public class IISIEvent : UnityEvent<int, int, string, int> { }

    [System.Serializable]
    public class IISSEvent : UnityEvent<int, int, string, string> { }

    [System.Serializable]
    public class IISBEvent : UnityEvent<int, int, string, bool> { }

    [System.Serializable]
    public class IISOEvent : UnityEvent<int, int, string, object> { }

    [System.Serializable]
    public class IIBFEvent : UnityEvent<int, int, bool, float> { }

    [System.Serializable]
    public class IIBIEvent : UnityEvent<int, int, bool, int> { }

    [System.Serializable]
    public class IIBSEvent : UnityEvent<int, int, bool, string> { }

    [System.Serializable]
    public class IIBBEvent : UnityEvent<int, int, bool, bool> { }

    [System.Serializable]
    public class IIBOEvent : UnityEvent<int, int, bool, object> { }

    [System.Serializable]
    public class IIOFEvent : UnityEvent<int, int, object, float> { }

    [System.Serializable]
    public class IIOIEvent : UnityEvent<int, int, object, int> { }

    [System.Serializable]
    public class IIOSEvent : UnityEvent<int, int, object, string> { }

    [System.Serializable]
    public class IIOBEvent : UnityEvent<int, int, object, bool> { }

    [System.Serializable]
    public class IIOOEvent : UnityEvent<int, int, object, object> { }

    [System.Serializable]
    public class ISFFEvent : UnityEvent<int, string, float, float> { }

    [System.Serializable]
    public class ISFIEvent : UnityEvent<int, string, float, int> { }

    [System.Serializable]
    public class ISFSEvent : UnityEvent<int, string, float, string> { }

    [System.Serializable]
    public class ISFBEvent : UnityEvent<int, string, float, bool> { }

    [System.Serializable]
    public class ISFOEvent : UnityEvent<int, string, float, object> { }

    [System.Serializable]
    public class ISIFEvent : UnityEvent<int, string, int, float> { }

    [System.Serializable]
    public class ISIIEvent : UnityEvent<int, string, int, int> { }

    [System.Serializable]
    public class ISISEvent : UnityEvent<int, string, int, string> { }

    [System.Serializable]
    public class ISIBEvent : UnityEvent<int, string, int, bool> { }

    [System.Serializable]
    public class ISIOEvent : UnityEvent<int, string, int, object> { }

    [System.Serializable]
    public class ISSFEvent : UnityEvent<int, string, string, float> { }

    [System.Serializable]
    public class ISSIEvent : UnityEvent<int, string, string, int> { }

    [System.Serializable]
    public class ISSSEvent : UnityEvent<int, string, string, string> { }

    [System.Serializable]
    public class ISSBEvent : UnityEvent<int, string, string, bool> { }

    [System.Serializable]
    public class ISSOEvent : UnityEvent<int, string, string, object> { }

    [System.Serializable]
    public class ISBFEvent : UnityEvent<int, string, bool, float> { }

    [System.Serializable]
    public class ISBIEvent : UnityEvent<int, string, bool, int> { }

    [System.Serializable]
    public class ISBSEvent : UnityEvent<int, string, bool, string> { }

    [System.Serializable]
    public class ISBBEvent : UnityEvent<int, string, bool, bool> { }

    [System.Serializable]
    public class ISBOEvent : UnityEvent<int, string, bool, object> { }

    [System.Serializable]
    public class ISOFEvent : UnityEvent<int, string, object, float> { }

    [System.Serializable]
    public class ISOIEvent : UnityEvent<int, string, object, int> { }

    [System.Serializable]
    public class ISOSEvent : UnityEvent<int, string, object, string> { }

    [System.Serializable]
    public class ISOBEvent : UnityEvent<int, string, object, bool> { }

    [System.Serializable]
    public class ISOOEvent : UnityEvent<int, string, object, object> { }

    [System.Serializable]
    public class IBFFEvent : UnityEvent<int, bool, float, float> { }

    [System.Serializable]
    public class IBFIEvent : UnityEvent<int, bool, float, int> { }

    [System.Serializable]
    public class IBFSEvent : UnityEvent<int, bool, float, string> { }

    [System.Serializable]
    public class IBFBEvent : UnityEvent<int, bool, float, bool> { }

    [System.Serializable]
    public class IBFOEvent : UnityEvent<int, bool, float, object> { }

    [System.Serializable]
    public class IBIFEvent : UnityEvent<int, bool, int, float> { }

    [System.Serializable]
    public class IBIIEvent : UnityEvent<int, bool, int, int> { }

    [System.Serializable]
    public class IBISEvent : UnityEvent<int, bool, int, string> { }

    [System.Serializable]
    public class IBIBEvent : UnityEvent<int, bool, int, bool> { }

    [System.Serializable]
    public class IBIOEvent : UnityEvent<int, bool, int, object> { }

    [System.Serializable]
    public class IBSFEvent : UnityEvent<int, bool, string, float> { }

    [System.Serializable]
    public class IBSIEvent : UnityEvent<int, bool, string, int> { }

    [System.Serializable]
    public class IBSSEvent : UnityEvent<int, bool, string, string> { }

    [System.Serializable]
    public class IBSBEvent : UnityEvent<int, bool, string, bool> { }

    [System.Serializable]
    public class IBSOEvent : UnityEvent<int, bool, string, object> { }

    [System.Serializable]
    public class IBBFEvent : UnityEvent<int, bool, bool, float> { }

    [System.Serializable]
    public class IBBIEvent : UnityEvent<int, bool, bool, int> { }

    [System.Serializable]
    public class IBBSEvent : UnityEvent<int, bool, bool, string> { }

    [System.Serializable]
    public class IBBBEvent : UnityEvent<int, bool, bool, bool> { }

    [System.Serializable]
    public class IBBOEvent : UnityEvent<int, bool, bool, object> { }

    [System.Serializable]
    public class IBOFEvent : UnityEvent<int, bool, object, float> { }

    [System.Serializable]
    public class IBOIEvent : UnityEvent<int, bool, object, int> { }

    [System.Serializable]
    public class IBOSEvent : UnityEvent<int, bool, object, string> { }

    [System.Serializable]
    public class IBOBEvent : UnityEvent<int, bool, object, bool> { }

    [System.Serializable]
    public class IBOOEvent : UnityEvent<int, bool, object, object> { }

    [System.Serializable]
    public class IOFFEvent : UnityEvent<int, object, float, float> { }

    [System.Serializable]
    public class IOFIEvent : UnityEvent<int, object, float, int> { }

    [System.Serializable]
    public class IOFSEvent : UnityEvent<int, object, float, string> { }

    [System.Serializable]
    public class IOFBEvent : UnityEvent<int, object, float, bool> { }

    [System.Serializable]
    public class IOFOEvent : UnityEvent<int, object, float, object> { }

    [System.Serializable]
    public class IOIFEvent : UnityEvent<int, object, int, float> { }

    [System.Serializable]
    public class IOIIEvent : UnityEvent<int, object, int, int> { }

    [System.Serializable]
    public class IOISEvent : UnityEvent<int, object, int, string> { }

    [System.Serializable]
    public class IOIBEvent : UnityEvent<int, object, int, bool> { }

    [System.Serializable]
    public class IOIOEvent : UnityEvent<int, object, int, object> { }

    [System.Serializable]
    public class IOSFEvent : UnityEvent<int, object, string, float> { }

    [System.Serializable]
    public class IOSIEvent : UnityEvent<int, object, string, int> { }

    [System.Serializable]
    public class IOSSEvent : UnityEvent<int, object, string, string> { }

    [System.Serializable]
    public class IOSBEvent : UnityEvent<int, object, string, bool> { }

    [System.Serializable]
    public class IOSOEvent : UnityEvent<int, object, string, object> { }

    [System.Serializable]
    public class IOBFEvent : UnityEvent<int, object, bool, float> { }

    [System.Serializable]
    public class IOBIEvent : UnityEvent<int, object, bool, int> { }

    [System.Serializable]
    public class IOBSEvent : UnityEvent<int, object, bool, string> { }

    [System.Serializable]
    public class IOBBEvent : UnityEvent<int, object, bool, bool> { }

    [System.Serializable]
    public class IOBOEvent : UnityEvent<int, object, bool, object> { }

    [System.Serializable]
    public class IOOFEvent : UnityEvent<int, object, object, float> { }

    [System.Serializable]
    public class IOOIEvent : UnityEvent<int, object, object, int> { }

    [System.Serializable]
    public class IOOSEvent : UnityEvent<int, object, object, string> { }

    [System.Serializable]
    public class IOOBEvent : UnityEvent<int, object, object, bool> { }

    [System.Serializable]
    public class IOOOEvent : UnityEvent<int, object, object, object> { }

    [System.Serializable]
    public class SFFFEvent : UnityEvent<string, float, float, float> { }

    [System.Serializable]
    public class SFFIEvent : UnityEvent<string, float, float, int> { }

    [System.Serializable]
    public class SFFSEvent : UnityEvent<string, float, float, string> { }

    [System.Serializable]
    public class SFFBEvent : UnityEvent<string, float, float, bool> { }

    [System.Serializable]
    public class SFFOEvent : UnityEvent<string, float, float, object> { }

    [System.Serializable]
    public class SFIFEvent : UnityEvent<string, float, int, float> { }

    [System.Serializable]
    public class SFIIEvent : UnityEvent<string, float, int, int> { }

    [System.Serializable]
    public class SFISEvent : UnityEvent<string, float, int, string> { }

    [System.Serializable]
    public class SFIBEvent : UnityEvent<string, float, int, bool> { }

    [System.Serializable]
    public class SFIOEvent : UnityEvent<string, float, int, object> { }

    [System.Serializable]
    public class SFSFEvent : UnityEvent<string, float, string, float> { }

    [System.Serializable]
    public class SFSIEvent : UnityEvent<string, float, string, int> { }

    [System.Serializable]
    public class SFSSEvent : UnityEvent<string, float, string, string> { }

    [System.Serializable]
    public class SFSBEvent : UnityEvent<string, float, string, bool> { }

    [System.Serializable]
    public class SFSOEvent : UnityEvent<string, float, string, object> { }

    [System.Serializable]
    public class SFBFEvent : UnityEvent<string, float, bool, float> { }

    [System.Serializable]
    public class SFBIEvent : UnityEvent<string, float, bool, int> { }

    [System.Serializable]
    public class SFBSEvent : UnityEvent<string, float, bool, string> { }

    [System.Serializable]
    public class SFBBEvent : UnityEvent<string, float, bool, bool> { }

    [System.Serializable]
    public class SFBOEvent : UnityEvent<string, float, bool, object> { }

    [System.Serializable]
    public class SFOFEvent : UnityEvent<string, float, object, float> { }

    [System.Serializable]
    public class SFOIEvent : UnityEvent<string, float, object, int> { }

    [System.Serializable]
    public class SFOSEvent : UnityEvent<string, float, object, string> { }

    [System.Serializable]
    public class SFOBEvent : UnityEvent<string, float, object, bool> { }

    [System.Serializable]
    public class SFOOEvent : UnityEvent<string, float, object, object> { }

    [System.Serializable]
    public class SIFFEvent : UnityEvent<string, int, float, float> { }

    [System.Serializable]
    public class SIFIEvent : UnityEvent<string, int, float, int> { }

    [System.Serializable]
    public class SIFSEvent : UnityEvent<string, int, float, string> { }

    [System.Serializable]
    public class SIFBEvent : UnityEvent<string, int, float, bool> { }

    [System.Serializable]
    public class SIFOEvent : UnityEvent<string, int, float, object> { }

    [System.Serializable]
    public class SIIFEvent : UnityEvent<string, int, int, float> { }

    [System.Serializable]
    public class SIIIEvent : UnityEvent<string, int, int, int> { }

    [System.Serializable]
    public class SIISEvent : UnityEvent<string, int, int, string> { }

    [System.Serializable]
    public class SIIBEvent : UnityEvent<string, int, int, bool> { }

    [System.Serializable]
    public class SIIOEvent : UnityEvent<string, int, int, object> { }

    [System.Serializable]
    public class SISFEvent : UnityEvent<string, int, string, float> { }

    [System.Serializable]
    public class SISIEvent : UnityEvent<string, int, string, int> { }

    [System.Serializable]
    public class SISSEvent : UnityEvent<string, int, string, string> { }

    [System.Serializable]
    public class SISBEvent : UnityEvent<string, int, string, bool> { }

    [System.Serializable]
    public class SISOEvent : UnityEvent<string, int, string, object> { }

    [System.Serializable]
    public class SIBFEvent : UnityEvent<string, int, bool, float> { }

    [System.Serializable]
    public class SIBIEvent : UnityEvent<string, int, bool, int> { }

    [System.Serializable]
    public class SIBSEvent : UnityEvent<string, int, bool, string> { }

    [System.Serializable]
    public class SIBBEvent : UnityEvent<string, int, bool, bool> { }

    [System.Serializable]
    public class SIBOEvent : UnityEvent<string, int, bool, object> { }

    [System.Serializable]
    public class SIOFEvent : UnityEvent<string, int, object, float> { }

    [System.Serializable]
    public class SIOIEvent : UnityEvent<string, int, object, int> { }

    [System.Serializable]
    public class SIOSEvent : UnityEvent<string, int, object, string> { }

    [System.Serializable]
    public class SIOBEvent : UnityEvent<string, int, object, bool> { }

    [System.Serializable]
    public class SIOOEvent : UnityEvent<string, int, object, object> { }

    [System.Serializable]
    public class SSFFEvent : UnityEvent<string, string, float, float> { }

    [System.Serializable]
    public class SSFIEvent : UnityEvent<string, string, float, int> { }

    [System.Serializable]
    public class SSFSEvent : UnityEvent<string, string, float, string> { }

    [System.Serializable]
    public class SSFBEvent : UnityEvent<string, string, float, bool> { }

    [System.Serializable]
    public class SSFOEvent : UnityEvent<string, string, float, object> { }

    [System.Serializable]
    public class SSIFEvent : UnityEvent<string, string, int, float> { }

    [System.Serializable]
    public class SSIIEvent : UnityEvent<string, string, int, int> { }

    [System.Serializable]
    public class SSISEvent : UnityEvent<string, string, int, string> { }

    [System.Serializable]
    public class SSIBEvent : UnityEvent<string, string, int, bool> { }

    [System.Serializable]
    public class SSIOEvent : UnityEvent<string, string, int, object> { }

    [System.Serializable]
    public class SSSFEvent : UnityEvent<string, string, string, float> { }

    [System.Serializable]
    public class SSSIEvent : UnityEvent<string, string, string, int> { }

    [System.Serializable]
    public class SSSSEvent : UnityEvent<string, string, string, string> { }

    [System.Serializable]
    public class SSSBEvent : UnityEvent<string, string, string, bool> { }

    [System.Serializable]
    public class SSSOEvent : UnityEvent<string, string, string, object> { }

    [System.Serializable]
    public class SSBFEvent : UnityEvent<string, string, bool, float> { }

    [System.Serializable]
    public class SSBIEvent : UnityEvent<string, string, bool, int> { }

    [System.Serializable]
    public class SSBSEvent : UnityEvent<string, string, bool, string> { }

    [System.Serializable]
    public class SSBBEvent : UnityEvent<string, string, bool, bool> { }

    [System.Serializable]
    public class SSBOEvent : UnityEvent<string, string, bool, object> { }

    [System.Serializable]
    public class SSOFEvent : UnityEvent<string, string, object, float> { }

    [System.Serializable]
    public class SSOIEvent : UnityEvent<string, string, object, int> { }

    [System.Serializable]
    public class SSOSEvent : UnityEvent<string, string, object, string> { }

    [System.Serializable]
    public class SSOBEvent : UnityEvent<string, string, object, bool> { }

    [System.Serializable]
    public class SSOOEvent : UnityEvent<string, string, object, object> { }

    [System.Serializable]
    public class SBFFEvent : UnityEvent<string, bool, float, float> { }

    [System.Serializable]
    public class SBFIEvent : UnityEvent<string, bool, float, int> { }

    [System.Serializable]
    public class SBFSEvent : UnityEvent<string, bool, float, string> { }

    [System.Serializable]
    public class SBFBEvent : UnityEvent<string, bool, float, bool> { }

    [System.Serializable]
    public class SBFOEvent : UnityEvent<string, bool, float, object> { }

    [System.Serializable]
    public class SBIFEvent : UnityEvent<string, bool, int, float> { }

    [System.Serializable]
    public class SBIIEvent : UnityEvent<string, bool, int, int> { }

    [System.Serializable]
    public class SBISEvent : UnityEvent<string, bool, int, string> { }

    [System.Serializable]
    public class SBIBEvent : UnityEvent<string, bool, int, bool> { }

    [System.Serializable]
    public class SBIOEvent : UnityEvent<string, bool, int, object> { }

    [System.Serializable]
    public class SBSFEvent : UnityEvent<string, bool, string, float> { }

    [System.Serializable]
    public class SBSIEvent : UnityEvent<string, bool, string, int> { }

    [System.Serializable]
    public class SBSSEvent : UnityEvent<string, bool, string, string> { }

    [System.Serializable]
    public class SBSBEvent : UnityEvent<string, bool, string, bool> { }

    [System.Serializable]
    public class SBSOEvent : UnityEvent<string, bool, string, object> { }

    [System.Serializable]
    public class SBBFEvent : UnityEvent<string, bool, bool, float> { }

    [System.Serializable]
    public class SBBIEvent : UnityEvent<string, bool, bool, int> { }

    [System.Serializable]
    public class SBBSEvent : UnityEvent<string, bool, bool, string> { }

    [System.Serializable]
    public class SBBBEvent : UnityEvent<string, bool, bool, bool> { }

    [System.Serializable]
    public class SBBOEvent : UnityEvent<string, bool, bool, object> { }

    [System.Serializable]
    public class SBOFEvent : UnityEvent<string, bool, object, float> { }

    [System.Serializable]
    public class SBOIEvent : UnityEvent<string, bool, object, int> { }

    [System.Serializable]
    public class SBOSEvent : UnityEvent<string, bool, object, string> { }

    [System.Serializable]
    public class SBOBEvent : UnityEvent<string, bool, object, bool> { }

    [System.Serializable]
    public class SBOOEvent : UnityEvent<string, bool, object, object> { }

    [System.Serializable]
    public class SOFFEvent : UnityEvent<string, object, float, float> { }

    [System.Serializable]
    public class SOFIEvent : UnityEvent<string, object, float, int> { }

    [System.Serializable]
    public class SOFSEvent : UnityEvent<string, object, float, string> { }

    [System.Serializable]
    public class SOFBEvent : UnityEvent<string, object, float, bool> { }

    [System.Serializable]
    public class SOFOEvent : UnityEvent<string, object, float, object> { }

    [System.Serializable]
    public class SOIFEvent : UnityEvent<string, object, int, float> { }

    [System.Serializable]
    public class SOIIEvent : UnityEvent<string, object, int, int> { }

    [System.Serializable]
    public class SOISEvent : UnityEvent<string, object, int, string> { }

    [System.Serializable]
    public class SOIBEvent : UnityEvent<string, object, int, bool> { }

    [System.Serializable]
    public class SOIOEvent : UnityEvent<string, object, int, object> { }

    [System.Serializable]
    public class SOSFEvent : UnityEvent<string, object, string, float> { }

    [System.Serializable]
    public class SOSIEvent : UnityEvent<string, object, string, int> { }

    [System.Serializable]
    public class SOSSEvent : UnityEvent<string, object, string, string> { }

    [System.Serializable]
    public class SOSBEvent : UnityEvent<string, object, string, bool> { }

    [System.Serializable]
    public class SOSOEvent : UnityEvent<string, object, string, object> { }

    [System.Serializable]
    public class SOBFEvent : UnityEvent<string, object, bool, float> { }

    [System.Serializable]
    public class SOBIEvent : UnityEvent<string, object, bool, int> { }

    [System.Serializable]
    public class SOBSEvent : UnityEvent<string, object, bool, string> { }

    [System.Serializable]
    public class SOBBEvent : UnityEvent<string, object, bool, bool> { }

    [System.Serializable]
    public class SOBOEvent : UnityEvent<string, object, bool, object> { }

    [System.Serializable]
    public class SOOFEvent : UnityEvent<string, object, object, float> { }

    [System.Serializable]
    public class SOOIEvent : UnityEvent<string, object, object, int> { }

    [System.Serializable]
    public class SOOSEvent : UnityEvent<string, object, object, string> { }

    [System.Serializable]
    public class SOOBEvent : UnityEvent<string, object, object, bool> { }

    [System.Serializable]
    public class SOOOEvent : UnityEvent<string, object, object, object> { }

    [System.Serializable]
    public class BFFFEvent : UnityEvent<bool, float, float, float> { }

    [System.Serializable]
    public class BFFIEvent : UnityEvent<bool, float, float, int> { }

    [System.Serializable]
    public class BFFSEvent : UnityEvent<bool, float, float, string> { }

    [System.Serializable]
    public class BFFBEvent : UnityEvent<bool, float, float, bool> { }

    [System.Serializable]
    public class BFFOEvent : UnityEvent<bool, float, float, object> { }

    [System.Serializable]
    public class BFIFEvent : UnityEvent<bool, float, int, float> { }

    [System.Serializable]
    public class BFIIEvent : UnityEvent<bool, float, int, int> { }

    [System.Serializable]
    public class BFISEvent : UnityEvent<bool, float, int, string> { }

    [System.Serializable]
    public class BFIBEvent : UnityEvent<bool, float, int, bool> { }

    [System.Serializable]
    public class BFIOEvent : UnityEvent<bool, float, int, object> { }

    [System.Serializable]
    public class BFSFEvent : UnityEvent<bool, float, string, float> { }

    [System.Serializable]
    public class BFSIEvent : UnityEvent<bool, float, string, int> { }

    [System.Serializable]
    public class BFSSEvent : UnityEvent<bool, float, string, string> { }

    [System.Serializable]
    public class BFSBEvent : UnityEvent<bool, float, string, bool> { }

    [System.Serializable]
    public class BFSOEvent : UnityEvent<bool, float, string, object> { }

    [System.Serializable]
    public class BFBFEvent : UnityEvent<bool, float, bool, float> { }

    [System.Serializable]
    public class BFBIEvent : UnityEvent<bool, float, bool, int> { }

    [System.Serializable]
    public class BFBSEvent : UnityEvent<bool, float, bool, string> { }

    [System.Serializable]
    public class BFBBEvent : UnityEvent<bool, float, bool, bool> { }

    [System.Serializable]
    public class BFBOEvent : UnityEvent<bool, float, bool, object> { }

    [System.Serializable]
    public class BFOFEvent : UnityEvent<bool, float, object, float> { }

    [System.Serializable]
    public class BFOIEvent : UnityEvent<bool, float, object, int> { }

    [System.Serializable]
    public class BFOSEvent : UnityEvent<bool, float, object, string> { }

    [System.Serializable]
    public class BFOBEvent : UnityEvent<bool, float, object, bool> { }

    [System.Serializable]
    public class BFOOEvent : UnityEvent<bool, float, object, object> { }

    [System.Serializable]
    public class BIFFEvent : UnityEvent<bool, int, float, float> { }

    [System.Serializable]
    public class BIFIEvent : UnityEvent<bool, int, float, int> { }

    [System.Serializable]
    public class BIFSEvent : UnityEvent<bool, int, float, string> { }

    [System.Serializable]
    public class BIFBEvent : UnityEvent<bool, int, float, bool> { }

    [System.Serializable]
    public class BIFOEvent : UnityEvent<bool, int, float, object> { }

    [System.Serializable]
    public class BIIFEvent : UnityEvent<bool, int, int, float> { }

    [System.Serializable]
    public class BIIIEvent : UnityEvent<bool, int, int, int> { }

    [System.Serializable]
    public class BIISEvent : UnityEvent<bool, int, int, string> { }

    [System.Serializable]
    public class BIIBEvent : UnityEvent<bool, int, int, bool> { }

    [System.Serializable]
    public class BIIOEvent : UnityEvent<bool, int, int, object> { }

    [System.Serializable]
    public class BISFEvent : UnityEvent<bool, int, string, float> { }

    [System.Serializable]
    public class BISIEvent : UnityEvent<bool, int, string, int> { }

    [System.Serializable]
    public class BISSEvent : UnityEvent<bool, int, string, string> { }

    [System.Serializable]
    public class BISBEvent : UnityEvent<bool, int, string, bool> { }

    [System.Serializable]
    public class BISOEvent : UnityEvent<bool, int, string, object> { }

    [System.Serializable]
    public class BIBFEvent : UnityEvent<bool, int, bool, float> { }

    [System.Serializable]
    public class BIBIEvent : UnityEvent<bool, int, bool, int> { }

    [System.Serializable]
    public class BIBSEvent : UnityEvent<bool, int, bool, string> { }

    [System.Serializable]
    public class BIBBEvent : UnityEvent<bool, int, bool, bool> { }

    [System.Serializable]
    public class BIBOEvent : UnityEvent<bool, int, bool, object> { }

    [System.Serializable]
    public class BIOFEvent : UnityEvent<bool, int, object, float> { }

    [System.Serializable]
    public class BIOIEvent : UnityEvent<bool, int, object, int> { }

    [System.Serializable]
    public class BIOSEvent : UnityEvent<bool, int, object, string> { }

    [System.Serializable]
    public class BIOBEvent : UnityEvent<bool, int, object, bool> { }

    [System.Serializable]
    public class BIOOEvent : UnityEvent<bool, int, object, object> { }

    [System.Serializable]
    public class BSFFEvent : UnityEvent<bool, string, float, float> { }

    [System.Serializable]
    public class BSFIEvent : UnityEvent<bool, string, float, int> { }

    [System.Serializable]
    public class BSFSEvent : UnityEvent<bool, string, float, string> { }

    [System.Serializable]
    public class BSFBEvent : UnityEvent<bool, string, float, bool> { }

    [System.Serializable]
    public class BSFOEvent : UnityEvent<bool, string, float, object> { }

    [System.Serializable]
    public class BSIFEvent : UnityEvent<bool, string, int, float> { }

    [System.Serializable]
    public class BSIIEvent : UnityEvent<bool, string, int, int> { }

    [System.Serializable]
    public class BSISEvent : UnityEvent<bool, string, int, string> { }

    [System.Serializable]
    public class BSIBEvent : UnityEvent<bool, string, int, bool> { }

    [System.Serializable]
    public class BSIOEvent : UnityEvent<bool, string, int, object> { }

    [System.Serializable]
    public class BSSFEvent : UnityEvent<bool, string, string, float> { }

    [System.Serializable]
    public class BSSIEvent : UnityEvent<bool, string, string, int> { }

    [System.Serializable]
    public class BSSSEvent : UnityEvent<bool, string, string, string> { }

    [System.Serializable]
    public class BSSBEvent : UnityEvent<bool, string, string, bool> { }

    [System.Serializable]
    public class BSSOEvent : UnityEvent<bool, string, string, object> { }

    [System.Serializable]
    public class BSBFEvent : UnityEvent<bool, string, bool, float> { }

    [System.Serializable]
    public class BSBIEvent : UnityEvent<bool, string, bool, int> { }

    [System.Serializable]
    public class BSBSEvent : UnityEvent<bool, string, bool, string> { }

    [System.Serializable]
    public class BSBBEvent : UnityEvent<bool, string, bool, bool> { }

    [System.Serializable]
    public class BSBOEvent : UnityEvent<bool, string, bool, object> { }

    [System.Serializable]
    public class BSOFEvent : UnityEvent<bool, string, object, float> { }

    [System.Serializable]
    public class BSOIEvent : UnityEvent<bool, string, object, int> { }

    [System.Serializable]
    public class BSOSEvent : UnityEvent<bool, string, object, string> { }

    [System.Serializable]
    public class BSOBEvent : UnityEvent<bool, string, object, bool> { }

    [System.Serializable]
    public class BSOOEvent : UnityEvent<bool, string, object, object> { }

    [System.Serializable]
    public class BBFFEvent : UnityEvent<bool, bool, float, float> { }

    [System.Serializable]
    public class BBFIEvent : UnityEvent<bool, bool, float, int> { }

    [System.Serializable]
    public class BBFSEvent : UnityEvent<bool, bool, float, string> { }

    [System.Serializable]
    public class BBFBEvent : UnityEvent<bool, bool, float, bool> { }

    [System.Serializable]
    public class BBFOEvent : UnityEvent<bool, bool, float, object> { }

    [System.Serializable]
    public class BBIFEvent : UnityEvent<bool, bool, int, float> { }

    [System.Serializable]
    public class BBIIEvent : UnityEvent<bool, bool, int, int> { }

    [System.Serializable]
    public class BBISEvent : UnityEvent<bool, bool, int, string> { }

    [System.Serializable]
    public class BBIBEvent : UnityEvent<bool, bool, int, bool> { }

    [System.Serializable]
    public class BBIOEvent : UnityEvent<bool, bool, int, object> { }

    [System.Serializable]
    public class BBSFEvent : UnityEvent<bool, bool, string, float> { }

    [System.Serializable]
    public class BBSIEvent : UnityEvent<bool, bool, string, int> { }

    [System.Serializable]
    public class BBSSEvent : UnityEvent<bool, bool, string, string> { }

    [System.Serializable]
    public class BBSBEvent : UnityEvent<bool, bool, string, bool> { }

    [System.Serializable]
    public class BBSOEvent : UnityEvent<bool, bool, string, object> { }

    [System.Serializable]
    public class BBBFEvent : UnityEvent<bool, bool, bool, float> { }

    [System.Serializable]
    public class BBBIEvent : UnityEvent<bool, bool, bool, int> { }

    [System.Serializable]
    public class BBBSEvent : UnityEvent<bool, bool, bool, string> { }

    [System.Serializable]
    public class BBBBEvent : UnityEvent<bool, bool, bool, bool> { }

    [System.Serializable]
    public class BBBOEvent : UnityEvent<bool, bool, bool, object> { }

    [System.Serializable]
    public class BBOFEvent : UnityEvent<bool, bool, object, float> { }

    [System.Serializable]
    public class BBOIEvent : UnityEvent<bool, bool, object, int> { }

    [System.Serializable]
    public class BBOSEvent : UnityEvent<bool, bool, object, string> { }

    [System.Serializable]
    public class BBOBEvent : UnityEvent<bool, bool, object, bool> { }

    [System.Serializable]
    public class BBOOEvent : UnityEvent<bool, bool, object, object> { }

    [System.Serializable]
    public class BOFFEvent : UnityEvent<bool, object, float, float> { }

    [System.Serializable]
    public class BOFIEvent : UnityEvent<bool, object, float, int> { }

    [System.Serializable]
    public class BOFSEvent : UnityEvent<bool, object, float, string> { }

    [System.Serializable]
    public class BOFBEvent : UnityEvent<bool, object, float, bool> { }

    [System.Serializable]
    public class BOFOEvent : UnityEvent<bool, object, float, object> { }

    [System.Serializable]
    public class BOIFEvent : UnityEvent<bool, object, int, float> { }

    [System.Serializable]
    public class BOIIEvent : UnityEvent<bool, object, int, int> { }

    [System.Serializable]
    public class BOISEvent : UnityEvent<bool, object, int, string> { }

    [System.Serializable]
    public class BOIBEvent : UnityEvent<bool, object, int, bool> { }

    [System.Serializable]
    public class BOIOEvent : UnityEvent<bool, object, int, object> { }

    [System.Serializable]
    public class BOSFEvent : UnityEvent<bool, object, string, float> { }

    [System.Serializable]
    public class BOSIEvent : UnityEvent<bool, object, string, int> { }

    [System.Serializable]
    public class BOSSEvent : UnityEvent<bool, object, string, string> { }

    [System.Serializable]
    public class BOSBEvent : UnityEvent<bool, object, string, bool> { }

    [System.Serializable]
    public class BOSOEvent : UnityEvent<bool, object, string, object> { }

    [System.Serializable]
    public class BOBFEvent : UnityEvent<bool, object, bool, float> { }

    [System.Serializable]
    public class BOBIEvent : UnityEvent<bool, object, bool, int> { }

    [System.Serializable]
    public class BOBSEvent : UnityEvent<bool, object, bool, string> { }

    [System.Serializable]
    public class BOBBEvent : UnityEvent<bool, object, bool, bool> { }

    [System.Serializable]
    public class BOBOEvent : UnityEvent<bool, object, bool, object> { }

    [System.Serializable]
    public class BOOFEvent : UnityEvent<bool, object, object, float> { }

    [System.Serializable]
    public class BOOIEvent : UnityEvent<bool, object, object, int> { }

    [System.Serializable]
    public class BOOSEvent : UnityEvent<bool, object, object, string> { }

    [System.Serializable]
    public class BOOBEvent : UnityEvent<bool, object, object, bool> { }

    [System.Serializable]
    public class BOOOEvent : UnityEvent<bool, object, object, object> { }

    [System.Serializable]
    public class OFFFEvent : UnityEvent<object, float, float, float> { }

    [System.Serializable]
    public class OFFIEvent : UnityEvent<object, float, float, int> { }

    [System.Serializable]
    public class OFFSEvent : UnityEvent<object, float, float, string> { }

    [System.Serializable]
    public class OFFBEvent : UnityEvent<object, float, float, bool> { }

    [System.Serializable]
    public class OFFOEvent : UnityEvent<object, float, float, object> { }

    [System.Serializable]
    public class OFIFEvent : UnityEvent<object, float, int, float> { }

    [System.Serializable]
    public class OFIIEvent : UnityEvent<object, float, int, int> { }

    [System.Serializable]
    public class OFISEvent : UnityEvent<object, float, int, string> { }

    [System.Serializable]
    public class OFIBEvent : UnityEvent<object, float, int, bool> { }

    [System.Serializable]
    public class OFIOEvent : UnityEvent<object, float, int, object> { }

    [System.Serializable]
    public class OFSFEvent : UnityEvent<object, float, string, float> { }

    [System.Serializable]
    public class OFSIEvent : UnityEvent<object, float, string, int> { }

    [System.Serializable]
    public class OFSSEvent : UnityEvent<object, float, string, string> { }

    [System.Serializable]
    public class OFSBEvent : UnityEvent<object, float, string, bool> { }

    [System.Serializable]
    public class OFSOEvent : UnityEvent<object, float, string, object> { }

    [System.Serializable]
    public class OFBFEvent : UnityEvent<object, float, bool, float> { }

    [System.Serializable]
    public class OFBIEvent : UnityEvent<object, float, bool, int> { }

    [System.Serializable]
    public class OFBSEvent : UnityEvent<object, float, bool, string> { }

    [System.Serializable]
    public class OFBBEvent : UnityEvent<object, float, bool, bool> { }

    [System.Serializable]
    public class OFBOEvent : UnityEvent<object, float, bool, object> { }

    [System.Serializable]
    public class OFOFEvent : UnityEvent<object, float, object, float> { }

    [System.Serializable]
    public class OFOIEvent : UnityEvent<object, float, object, int> { }

    [System.Serializable]
    public class OFOSEvent : UnityEvent<object, float, object, string> { }

    [System.Serializable]
    public class OFOBEvent : UnityEvent<object, float, object, bool> { }

    [System.Serializable]
    public class OFOOEvent : UnityEvent<object, float, object, object> { }

    [System.Serializable]
    public class OIFFEvent : UnityEvent<object, int, float, float> { }

    [System.Serializable]
    public class OIFIEvent : UnityEvent<object, int, float, int> { }

    [System.Serializable]
    public class OIFSEvent : UnityEvent<object, int, float, string> { }

    [System.Serializable]
    public class OIFBEvent : UnityEvent<object, int, float, bool> { }

    [System.Serializable]
    public class OIFOEvent : UnityEvent<object, int, float, object> { }

    [System.Serializable]
    public class OIIFEvent : UnityEvent<object, int, int, float> { }

    [System.Serializable]
    public class OIIIEvent : UnityEvent<object, int, int, int> { }

    [System.Serializable]
    public class OIISEvent : UnityEvent<object, int, int, string> { }

    [System.Serializable]
    public class OIIBEvent : UnityEvent<object, int, int, bool> { }

    [System.Serializable]
    public class OIIOEvent : UnityEvent<object, int, int, object> { }

    [System.Serializable]
    public class OISFEvent : UnityEvent<object, int, string, float> { }

    [System.Serializable]
    public class OISIEvent : UnityEvent<object, int, string, int> { }

    [System.Serializable]
    public class OISSEvent : UnityEvent<object, int, string, string> { }

    [System.Serializable]
    public class OISBEvent : UnityEvent<object, int, string, bool> { }

    [System.Serializable]
    public class OISOEvent : UnityEvent<object, int, string, object> { }

    [System.Serializable]
    public class OIBFEvent : UnityEvent<object, int, bool, float> { }

    [System.Serializable]
    public class OIBIEvent : UnityEvent<object, int, bool, int> { }

    [System.Serializable]
    public class OIBSEvent : UnityEvent<object, int, bool, string> { }

    [System.Serializable]
    public class OIBBEvent : UnityEvent<object, int, bool, bool> { }

    [System.Serializable]
    public class OIBOEvent : UnityEvent<object, int, bool, object> { }

    [System.Serializable]
    public class OIOFEvent : UnityEvent<object, int, object, float> { }

    [System.Serializable]
    public class OIOIEvent : UnityEvent<object, int, object, int> { }

    [System.Serializable]
    public class OIOSEvent : UnityEvent<object, int, object, string> { }

    [System.Serializable]
    public class OIOBEvent : UnityEvent<object, int, object, bool> { }

    [System.Serializable]
    public class OIOOEvent : UnityEvent<object, int, object, object> { }

    [System.Serializable]
    public class OSFFEvent : UnityEvent<object, string, float, float> { }

    [System.Serializable]
    public class OSFIEvent : UnityEvent<object, string, float, int> { }

    [System.Serializable]
    public class OSFSEvent : UnityEvent<object, string, float, string> { }

    [System.Serializable]
    public class OSFBEvent : UnityEvent<object, string, float, bool> { }

    [System.Serializable]
    public class OSFOEvent : UnityEvent<object, string, float, object> { }

    [System.Serializable]
    public class OSIFEvent : UnityEvent<object, string, int, float> { }

    [System.Serializable]
    public class OSIIEvent : UnityEvent<object, string, int, int> { }

    [System.Serializable]
    public class OSISEvent : UnityEvent<object, string, int, string> { }

    [System.Serializable]
    public class OSIBEvent : UnityEvent<object, string, int, bool> { }

    [System.Serializable]
    public class OSIOEvent : UnityEvent<object, string, int, object> { }

    [System.Serializable]
    public class OSSFEvent : UnityEvent<object, string, string, float> { }

    [System.Serializable]
    public class OSSIEvent : UnityEvent<object, string, string, int> { }

    [System.Serializable]
    public class OSSSEvent : UnityEvent<object, string, string, string> { }

    [System.Serializable]
    public class OSSBEvent : UnityEvent<object, string, string, bool> { }

    [System.Serializable]
    public class OSSOEvent : UnityEvent<object, string, string, object> { }

    [System.Serializable]
    public class OSBFEvent : UnityEvent<object, string, bool, float> { }

    [System.Serializable]
    public class OSBIEvent : UnityEvent<object, string, bool, int> { }

    [System.Serializable]
    public class OSBSEvent : UnityEvent<object, string, bool, string> { }

    [System.Serializable]
    public class OSBBEvent : UnityEvent<object, string, bool, bool> { }

    [System.Serializable]
    public class OSBOEvent : UnityEvent<object, string, bool, object> { }

    [System.Serializable]
    public class OSOFEvent : UnityEvent<object, string, object, float> { }

    [System.Serializable]
    public class OSOIEvent : UnityEvent<object, string, object, int> { }

    [System.Serializable]
    public class OSOSEvent : UnityEvent<object, string, object, string> { }

    [System.Serializable]
    public class OSOBEvent : UnityEvent<object, string, object, bool> { }

    [System.Serializable]
    public class OSOOEvent : UnityEvent<object, string, object, object> { }

    [System.Serializable]
    public class OBFFEvent : UnityEvent<object, bool, float, float> { }

    [System.Serializable]
    public class OBFIEvent : UnityEvent<object, bool, float, int> { }

    [System.Serializable]
    public class OBFSEvent : UnityEvent<object, bool, float, string> { }

    [System.Serializable]
    public class OBFBEvent : UnityEvent<object, bool, float, bool> { }

    [System.Serializable]
    public class OBFOEvent : UnityEvent<object, bool, float, object> { }

    [System.Serializable]
    public class OBIFEvent : UnityEvent<object, bool, int, float> { }

    [System.Serializable]
    public class OBIIEvent : UnityEvent<object, bool, int, int> { }

    [System.Serializable]
    public class OBISEvent : UnityEvent<object, bool, int, string> { }

    [System.Serializable]
    public class OBIBEvent : UnityEvent<object, bool, int, bool> { }

    [System.Serializable]
    public class OBIOEvent : UnityEvent<object, bool, int, object> { }

    [System.Serializable]
    public class OBSFEvent : UnityEvent<object, bool, string, float> { }

    [System.Serializable]
    public class OBSIEvent : UnityEvent<object, bool, string, int> { }

    [System.Serializable]
    public class OBSSEvent : UnityEvent<object, bool, string, string> { }

    [System.Serializable]
    public class OBSBEvent : UnityEvent<object, bool, string, bool> { }

    [System.Serializable]
    public class OBSOEvent : UnityEvent<object, bool, string, object> { }

    [System.Serializable]
    public class OBBFEvent : UnityEvent<object, bool, bool, float> { }

    [System.Serializable]
    public class OBBIEvent : UnityEvent<object, bool, bool, int> { }

    [System.Serializable]
    public class OBBSEvent : UnityEvent<object, bool, bool, string> { }

    [System.Serializable]
    public class OBBBEvent : UnityEvent<object, bool, bool, bool> { }

    [System.Serializable]
    public class OBBOEvent : UnityEvent<object, bool, bool, object> { }

    [System.Serializable]
    public class OBOFEvent : UnityEvent<object, bool, object, float> { }

    [System.Serializable]
    public class OBOIEvent : UnityEvent<object, bool, object, int> { }

    [System.Serializable]
    public class OBOSEvent : UnityEvent<object, bool, object, string> { }

    [System.Serializable]
    public class OBOBEvent : UnityEvent<object, bool, object, bool> { }

    [System.Serializable]
    public class OBOOEvent : UnityEvent<object, bool, object, object> { }

    [System.Serializable]
    public class OOFFEvent : UnityEvent<object, object, float, float> { }

    [System.Serializable]
    public class OOFIEvent : UnityEvent<object, object, float, int> { }

    [System.Serializable]
    public class OOFSEvent : UnityEvent<object, object, float, string> { }

    [System.Serializable]
    public class OOFBEvent : UnityEvent<object, object, float, bool> { }

    [System.Serializable]
    public class OOFOEvent : UnityEvent<object, object, float, object> { }

    [System.Serializable]
    public class OOIFEvent : UnityEvent<object, object, int, float> { }

    [System.Serializable]
    public class OOIIEvent : UnityEvent<object, object, int, int> { }

    [System.Serializable]
    public class OOISEvent : UnityEvent<object, object, int, string> { }

    [System.Serializable]
    public class OOIBEvent : UnityEvent<object, object, int, bool> { }

    [System.Serializable]
    public class OOIOEvent : UnityEvent<object, object, int, object> { }

    [System.Serializable]
    public class OOSFEvent : UnityEvent<object, object, string, float> { }

    [System.Serializable]
    public class OOSIEvent : UnityEvent<object, object, string, int> { }

    [System.Serializable]
    public class OOSSEvent : UnityEvent<object, object, string, string> { }

    [System.Serializable]
    public class OOSBEvent : UnityEvent<object, object, string, bool> { }

    [System.Serializable]
    public class OOSOEvent : UnityEvent<object, object, string, object> { }

    [System.Serializable]
    public class OOBFEvent : UnityEvent<object, object, bool, float> { }

    [System.Serializable]
    public class OOBIEvent : UnityEvent<object, object, bool, int> { }

    [System.Serializable]
    public class OOBSEvent : UnityEvent<object, object, bool, string> { }

    [System.Serializable]
    public class OOBBEvent : UnityEvent<object, object, bool, bool> { }

    [System.Serializable]
    public class OOBOEvent : UnityEvent<object, object, bool, object> { }

    [System.Serializable]
    public class OOOFEvent : UnityEvent<object, object, object, float> { }

    [System.Serializable]
    public class OOOIEvent : UnityEvent<object, object, object, int> { }

    [System.Serializable]
    public class OOOSEvent : UnityEvent<object, object, object, string> { }

    [System.Serializable]
    public class OOOBEvent : UnityEvent<object, object, object, bool> { }

    [System.Serializable]
    public class OOOOEvent : UnityEvent<object, object, object, object> { }

}
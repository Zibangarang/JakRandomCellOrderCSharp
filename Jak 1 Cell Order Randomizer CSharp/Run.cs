
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Run
{

    private object gameIconField;

    private string gameNameField;

    private string categoryNameField;

    private RunMetadata metadataField;

    private string offsetField;

    private byte attemptCountField;

    private object attemptHistoryField;

    private RunSegment[] segmentsField;

    private object autoSplitterSettingsField;

    private string versionField;

    /// <remarks/>
    public object GameIcon
    {
        get
        {
            return this.gameIconField;
        }
        set
        {
            this.gameIconField = value;
        }
    }

    /// <remarks/>
    public string GameName
    {
        get
        {
            return this.gameNameField;
        }
        set
        {
            this.gameNameField = value;
        }
    }

    /// <remarks/>
    public string CategoryName
    {
        get
        {
            return this.categoryNameField;
        }
        set
        {
            this.categoryNameField = value;
        }
    }

    /// <remarks/>
    public RunMetadata Metadata
    {
        get
        {
            return this.metadataField;
        }
        set
        {
            this.metadataField = value;
        }
    }

    /// <remarks/>
    public string Offset
    {
        get
        {
            return this.offsetField;
        }
        set
        {
            this.offsetField = value;
        }
    }

    /// <remarks/>
    public byte AttemptCount
    {
        get
        {
            return this.attemptCountField;
        }
        set
        {
            this.attemptCountField = value;
        }
    }

    /// <remarks/>
    public object AttemptHistory
    {
        get
        {
            return this.attemptHistoryField;
        }
        set
        {
            this.attemptHistoryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Segment", IsNullable = false)]
    public RunSegment[] Segments
    {
        get
        {
            return this.segmentsField;
        }
        set
        {
            this.segmentsField = value;
        }
    }

    /// <remarks/>
    public object AutoSplitterSettings
    {
        get
        {
            return this.autoSplitterSettingsField;
        }
        set
        {
            this.autoSplitterSettingsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunMetadata
{

    private RunMetadataRun runField;

    private RunMetadataPlatform platformField;

    private object regionField;

    private object variablesField;

    /// <remarks/>
    public RunMetadataRun Run
    {
        get
        {
            return this.runField;
        }
        set
        {
            this.runField = value;
        }
    }

    /// <remarks/>
    public RunMetadataPlatform Platform
    {
        get
        {
            return this.platformField;
        }
        set
        {
            this.platformField = value;
        }
    }

    /// <remarks/>
    public object Region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }

    /// <remarks/>
    public object Variables
    {
        get
        {
            return this.variablesField;
        }
        set
        {
            this.variablesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunMetadataRun
{

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunMetadataPlatform
{

    private string usesEmulatorField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string usesEmulator
    {
        get
        {
            return this.usesEmulatorField;
        }
        set
        {
            this.usesEmulatorField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunSegment
{

    private string nameField;

    private object iconField;

    private RunSegmentSplitTimes splitTimesField;

    private object bestSegmentTimeField;

    private object segmentHistoryField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public object Icon
    {
        get
        {
            return this.iconField;
        }
        set
        {
            this.iconField = value;
        }
    }

    /// <remarks/>
    public RunSegmentSplitTimes SplitTimes
    {
        get
        {
            return this.splitTimesField;
        }
        set
        {
            this.splitTimesField = value;
        }
    }

    /// <remarks/>
    public object BestSegmentTime
    {
        get
        {
            return this.bestSegmentTimeField;
        }
        set
        {
            this.bestSegmentTimeField = value;
        }
    }

    /// <remarks/>
    public object SegmentHistory
    {
        get
        {
            return this.segmentHistoryField;
        }
        set
        {
            this.segmentHistoryField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunSegmentSplitTimes
{

    private RunSegmentSplitTimesSplitTime splitTimeField;

    /// <remarks/>
    public RunSegmentSplitTimesSplitTime SplitTime
    {
        get
        {
            return this.splitTimeField;
        }
        set
        {
            this.splitTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RunSegmentSplitTimesSplitTime
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}


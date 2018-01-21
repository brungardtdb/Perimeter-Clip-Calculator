using System;


class Corner_Zone
{
    private double _zoneSize; // instance variable

    // property to get and set the zoneSize instance variable
    // (zone size called out by design)
    public double ZoneSize
    {
        get
        {
            return _zoneSize;
        }
        set
        {
            _zoneSize = value;
        }
    }

    private double _verticalZoneSize; // instance variable

    // property to get and set the zoneSize instance variable
    // (zone size called out by design)
    public double VerticalZoneSize
    {
        get
        {
            return _verticalZoneSize;
        }
        set
        {
            _verticalZoneSize = value;
        }
    }

    private double _startFinishDim; // instance variable

    // property to get and set the startFinishDim instance variable
    // (Start / Finish dimension for roof sheeting)
    public double StartFinishDim
    {
        get
        {
            return _startFinishDim;
        }
        set
        {
            _startFinishDim = value;
        }
    }

    private double _cornerZoneActual; // instance variable

    // property to get and set the cornerZoneActual instance variable
    // (actual size of corner zone)
    public double CornerZoneActual
    {
        get
        {
            return _cornerZoneActual;
        }
        set
        {
            _cornerZoneActual = _zoneSize - _startFinishDim;
        }
    }


    private int _clipsPerPurlin; // instance variable

    // property to get and set the clipsPerPurlin instance variable
    // (amount of clips to go on each run of purlins)
    public int ClipsPerPurlin
    {
        get
        {
            return _clipsPerPurlin;
        }
        set
        {
            _clipsPerPurlin = value;
        }
    }

    private int _totalPerimeterClips; // instance variable

    // property to get and set the clipsPerPurlin instance variable
    // (amount of clips to go on each run of purlins)
    public int TotalPerimeterClips
    {
        get
        {
            return _totalPerimeterClips;
        }
        set
        {
            _totalPerimeterClips = value;
        }
    }

    private int _panelsInCornerZone; // instance variable

    // property to get and set the panelsInCornerZoe instance variable
    // (amount of panels in the corner zone)
    public int PanelsInCornerZone
    {
        get
        {
            return _panelsInCornerZone;
        }
        set
        {
            _panelsInCornerZone = value;
        }
    }


    private bool _correctStartFinish = false;

    // property to get and set the correctPanel instance variable
    // (property to terminate panel qty loop)
    public bool CorrectStartFinish
    {
        get
        {
            return _correctStartFinish;
        }
        set
        {
            _correctStartFinish = value;
        }
    }


    private bool _correctPurlinSpace = false;

    // property to get and set the correctPanel instance variable
    // (property to terminate panel qty loop)
    public bool CorrectPurlinSpace
    {
        get
        {
            return _correctPurlinSpace;
        }
        set
        {
            _correctPurlinSpace = value;
        }
    }


}



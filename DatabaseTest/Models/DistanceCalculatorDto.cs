
public class Rootobject
{
    public string authenticationResultCode { get; set; }
    public string brandLogoUri { get; set; }
    public string copyright { get; set; }
    public Resourceset[] resourceSets { get; set; }
    public int statusCode { get; set; }
    public string statusDescription { get; set; }
    public string traceId { get; set; }
}

public class Resourceset
{
    public int estimatedTotal { get; set; }
    public Resource[] resources { get; set; }
}

public class Resource
{
    public string __type { get; set; }
    public Destination[] destinations { get; set; }
    public Origin[] origins { get; set; }
    public Result[] results { get; set; }
}

public class Destination
{
    public float latitude { get; set; }
    public float longitude { get; set; }
}

public class Origin
{
    public float latitude { get; set; }
    public float longitude { get; set; }
}

public class Result
{
    public int destinationIndex { get; set; }
    public int originIndex { get; set; }
    public int totalWalkDuration { get; set; }
    public float travelDistance { get; set; }
    public float travelDuration { get; set; }
}

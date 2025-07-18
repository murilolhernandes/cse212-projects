public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> features { get; set; }
}
public class Feature
    {
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public string place { get; set; }
        public double? mag { get; set; }

    }

    public class Geometry
    {
        public double? depth { get; set; }
    }
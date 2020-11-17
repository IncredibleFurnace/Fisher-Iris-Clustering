namespace IrisClustering
{
    class Iris
    {
        public double DIM1;
        public double DIM2;
        public double DIM3;
        public double DIM4;
        public string KIND;

        public Iris(double dim1, double dim2, double dim3, double dim4, string kind)
        {
            DIM1 = dim1;
            DIM2 = dim2;
            DIM3 = dim3;
            DIM4 = dim4;
            KIND = kind;
        }

        public double DistanceSquare(Iris another)
        {
            var DD1 = DIM1 - another.DIM1;
            var DD2 = DIM2 - another.DIM2;
            var DD3 = DIM3 - another.DIM3;
            var DD4 = DIM4 - another.DIM4;
            return DD1 * DD1 + DD2 * DD2 + DD3 * DD3 + DD4 * DD4;
        }
    }
}

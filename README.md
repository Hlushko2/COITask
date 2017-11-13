# COITask
Дана бібліотека дозволяє створити контейнер для точок 1D, 2D i 3D.
Основний клас в бібліотеці- Containers. Віт містить в собі ліст Container, який містить ліст AMatrix.
AMatrix- абстрактний клас від якого наслідуються MatrixX, MatrixXY i MatrixXYZ,
котрі маюсь в собі ліст PositionX, PositionXY i PositionXYZ відповідно.
Кожна з Position містить в собі ліст точок 1D, 2D i 3D відповідно.
Кожен клас наслідує інтерфейс IEnumerable і має перегружений індексатор.
# Клас Containers має такі властивості:
        public int CountContainers { get; protected set; }- кількість контейнерів
        public int CountInEachConainerMatrixX { get; protected set; }- кількість матриць Х в кожному контейнері
        public int CountInEachConainerMatrixXY { get; protected set; }- кількість матриць ХY в кожному контейнері
        public int CountInEachConainerMatrixXYZ { get; protected set; }- кількість матриць ХYZ в кожному контейнері
        public int CountPositions { get; protected set; }- кількість позицій в кожній матриці
        public int CountPoints3D { get; protected set; }-кількість точок 3D в усіх позиціях усіх матриць ХYZ
# Клас Containers має такі конструктори:
1.        public Containers()
2.        public Containers(int CountContainers)- створює обєкт з CountContainers- кількістю контейнерів
3.        public Containers(int CountContainers, int CountMatrixX, int CountMatrixXY, int CountMatrixXYZ)- створює
          обєкт з CountContainers- кількістю контейнерів і CountMatrixX, CountMatrixXY, CountMatrixXYZ- кількістю
          матриць Х, ХY, ХYZ відповідно
4.        public Containers(int CountContainers, int CountMatrixX,int CountMatrixXY, int CountMatrixXYZ,
                          int CountPositions)- створює
          обєкт з CountContainers- кількістю контейнерів і CountMatrixX, CountMatrixXY, CountMatrixXYZ- кількістю
          матриць Х, ХY, ХYZ відповідно і CountPositions- позицій в кожному контейнері
 # Клас Containers має такі методи:  
 1.       public void AddContainers(int CountContainers)
 2.       public void AddMatrixInEachContainer(TypeMatrix typeMatrix, int CountMatrix)
 3.       public void AddPositionsInEachMatrix(int countPositions)
 4.       public void AddPoint1D(int numberContainer, int numberMatrix, int numberPosition, Point1D<T> point1D)
 5.       public void AddRangePoint1D(int numberContainer, int numberMatrix, int numberPosition,
                                     List<Point1D<T>> colectionPoint1D)
 6.       public void AllocateMemoryForPoints2DInEachContainer(int NumberMatrixXY, int NumberPosition,
                                                              int countPoint2D)
 7.       public void SetRaingPoint2DInAllocatedMemory(int NumberContainer, int NumberMatrixXY,
            int NumberPosition, List<Point2D<T>> colectionPoint2D)
 8.       public void AllocateMemoryForPoints3D(int countPoints3D)
 9.       public void SetRaingPoint3DInAllocatedMemory(int NumberContainer, int NumberMatrixXYZ,
            int NumberPosition, List<Point3D<T>> colectionPoint3D)
        

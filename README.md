
Problem One

 to run the code : initiate new instance of plateauProject using the required input data, to get the final output you will find it in state property of the plateauProject.
it will be somthing like that :
            plateauProject project1 = new plateauProject(input);
            string result = project1.state;



the Class plateauProject will represent the journey to plateau and rovers squad- which will hold all the information about Plateua and the Rovers squad (in the real world we gonna need to add more of plateau's info. as properties such as plateausLocation ,plateausName  ..est) 
the class Rover will represent one Rover which will hold all informations about one Rover

in the constructor of this class we parse the input instructions as following
- splitting the instructions into list of lines 
- validate that lines count is more that 3 and odd number 
- parse the first line to know the upper right plateauCoordinate
- loop through the rest of lines two by two (the two line belong to one rover)
- parse the first line to initialize the rover's position.
- loop throw each char in the second line  and excute each char according to what mentioned in the requrments
-efentiolly you will have list of rovers list its final position 

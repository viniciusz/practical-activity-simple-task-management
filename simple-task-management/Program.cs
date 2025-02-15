var firstTaskName = "";
var isFirstTaskComplete = false;

var secondTaskName = "";
var isSecondTaskComplete = false;

var thirdTaskName = "";
var isThirdTaskComplete = false;

for(int i = 1; i <= 3; i++){
    var input = ReadTaskInput();    
    if(string.IsNullOrWhiteSpace(firstTaskName))
        firstTaskName = input;
    else if (string.IsNullOrWhiteSpace(secondTaskName))
        secondTaskName = input;
    else if(string.IsNullOrWhiteSpace(thirdTaskName))
        thirdTaskName = input;
    else
        Console.WriteLine("Sorry, the task list is full.");

    var inputTaskNumber = GetTaskToComplete();

    var taskNumber = ValidateTaskNumber(inputTaskNumber);

    if(taskNumber == 1)
        isFirstTaskComplete = true;
    else if (taskNumber == 2)
        isSecondTaskComplete = true;
    else if(taskNumber == 3)
        isThirdTaskComplete = true;
    else 
        Console.WriteLine("Invalid task value");
}

DisplayTaskAndStatus(firstTaskName, isFirstTaskComplete);
DisplayTaskAndStatus(secondTaskName, isSecondTaskComplete);
DisplayTaskAndStatus(thirdTaskName, isThirdTaskComplete);


void DisplayTaskAndStatus(string? taskName, bool taskStatus){
    if(taskStatus)
        Console.WriteLine("Task: "+taskName+" Status: completed");
    else
        Console.WriteLine("Task: "+taskName+" Status: pending");
}
    

static int ValidateTaskNumber(string? taskNumber)
    => taskNumber switch {
        "1" => 1,
        "2" => 2,
        "3" => 3,
        _ => 0
    };

static string? GetTaskToComplete()
{
    Console.WriteLine("Choose task number to complete. Valid numbers are 1, 2 or 3");
    return Console.ReadLine();
}

static string? ReadTaskInput(){
    Console.WriteLine("Insert your task");
    return Console.ReadLine();
}
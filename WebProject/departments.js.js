function check_form(form)
{ 
   if(form.NAME.value == "")
    {
        alert("Error: Your name cannot be blanck!");
        form.NAME.focus();
        return false ;
    }
    else
    {
        removeAlert();
    }
     if(form.ID.value == "")
    {
        alert("Error: Your ID cannot be blanck!");
        form.ID.focus();
        return false ;
    }
    else
    {
        removeAlert();
    }
    

     if(form.GBA.value == "")
      if(form.GBA.value < 4)
      {
        alert("Error: Your Gpa cannot be blanck or cannot be less than 4!");
        form.GBA.focus();
        return false ;
      }
     else
      {
          removeAlert();
      }

    arr1 = /[0-9]/;
     if(!arr1.test(form.ID.value))
    {
        alert("Error: Your ID must contain 8 number from (0-9)!");
        form.ID.focus();
        return false ;
    }

    else
    {
        removeAlert();
    }

    arr2 = /[0-9]/;
     if(!arr2.test(form.GPA.value))
    {
        alert("Error: Your Gpa must contain a number from (0-9)!");
        form.GPA.focus();
        return false ;
    }
    else
    {
        removeAlert();
    } 

    arr3 = /[a-z]/ ;
    if(!arr3.test(form.NAME.value))
    {
        alert("Error: Your name must contain letters from (a-z)!");
        form.NAME.focus();
        return false ;
    }
    else
    {
        removeAlert();
    }
     if(form.option1.value == "0" )
    {
        alert("Error: You MUST Enter your year!");
        form.option.focus();
        return false ;
    }
    else
    {
        removeAlert();
    }
    

     if(form.level.value <3 )
      if(form.Student_Department.value != "General")
      {  
        alert("Error: Your department must be General!");
        form.Student_Department.focus();
        return false ;
      }
      else
    {
        removeAlert();
    }

      
}
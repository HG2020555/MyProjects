function checkForm()
{
    var x= document.forms["form1"]["Sname"].value;;
    var b= document.forms["form1"]["dob"].value;
    var y= document.forms["form1"]["id"].value;
    var g= document.forms["form1"]["gpa"].value;
    var m= document.forms["form1"]["mail"].value;
  //let spa = 0;
  //let no=0;
// for(let i =  0 ; i < Sname.length;i++)
// {
    if(x == "" || y == "" || b == "" || g == "" || m == ""){
        //spa ++;
        alert("Please Enter the full name of Student Name's scoop !----");
    //document.getElementById("Sname").focus();
    return false;
    }
    // else
    // {
    //     no++;
    // }
// }
// if(spa < 2)
// {
//     alert("Please Enter the full name of Student Name's scoop !----");
//     document.getElementById("Sname").focus();
//     return false;

// }
 if(b > "1-1-2004")
 {
     alert("Year of birth can't be greater than 1-1-2004  !----");
  //   document.getElementById("dob").focus();
    return false;
 }
if (y < "202001")
 {
     alert("The Student's ID can't be less than 202001 !----");
//     document.getElementById("id").focus();
     return false;
 }
 if(g < "0")
 {
     alert("Student's GPA can't be zero !----");
//     document.getElementById("gpa").focus();
    return false;
 }

 if (/^(([^<>()[]\.,;:\s@"]+(.[^<>()[]\.,;:\s@"]+)*)|(".+"))@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}])|(([a-zA-Z-0-9]+.)+[a-zA-Z]{2,}))$/.test(m) == false)
{
    alert("You have entered an invalid email address!")
}
}
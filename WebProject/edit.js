function fun()
{
    var x = document.forms["form"]["First name"].value;
    var y = document.forms["form"]["Last name"].value;
    var z = document.forms["form"]["id"].value;
    if(x == "" || x == null)
    {
    alert("Enter the first name");
    document.getElementById("fn").focus();
    return false;}
    if(y == "" || y == null)
    {
    alert("Enter the last name");
    document.getElementById("ln").focus();
    return false;}
    if(z <20200001 || z > 20209999)
    {
    alert("Invalid ID");
    document.getElementById("id").focus();
    return false;}
}

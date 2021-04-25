function DBfunction(id,user,pass,lang) {
	localStorage.setItem("id", id);
	localStorage.setItem("username", user);
	localStorage.setItem("password", pass);
	localStorage.setItem("language", lang);
}

function logout()
{
	localStorage.clear();
	window.location.href = 'Login.aspx';
}
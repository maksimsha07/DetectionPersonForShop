<template>
  <b-container fluid class="d-flex h-100 justify-content-center align-items-center p-0">
      <form id="registrationForm" @submit.prevent = "registerClick">
            <div id="errors" class="alert alert-danger" style="display:none;"></div>
            <div class="form-group" id="modalrowsize">
                <label for="registrationInputLogin">Логин</label>
                <input type="Login" class="form-control" v-model="Login" id="registrationInputLogin" >
            </div>
            <div class="form-group row" id="modalrowsize">
                <div class="form-group">
                    <label for="registrationInputEmail">Почта</label>
                    <input type="Email" class="form-control" id="registrationInputEmail" v-model="Email"  placeholder="Enter email">
                </div>
            </div>
            <div class="form-group row" id="modalrowsize">
                <div class="form-group col-md-6">
                    <label for="registrationInputPassword">Пароль</label>
                    <input type="Password" class="form-control" id="registrationInputPassword"  v-model="Password" >
                </div>
                <div class="form-group col-md-6">
                    <label for="registrationInputPasswordReturn">Повтор пароля</label>
                    <input type="Password" class="form-control" id="registrationInputPasswordReturn"  v-model="CheckPassword">
                </div>
            </div>
            <div class="d-flex h-100 justify-content-center align-items-center p-0" style="margin:5px">
                <b-button type="submit" form="registrationForm" variant="secondary">Зарегистрироваться</b-button>
            </div>
        </form>
  </b-container>
</template>

<script>
var tokenKey = "accessToken";
var lg = "login";
export default{
    data(){
        return{
            Login: "",
            Email: null,
            Password: "",
            CheckPassword: ""
        }
    },
    methods:
    {
        async registerClick(){
            if(this.Password == this.CheckPassword){           
                const response = await fetch("http://localhost:56063/api/user",
                {
                    method: "POST",
                    headers: {"Accept": "application/json", "Content-Type": "application/json"},
                    body: JSON.stringify({
                            Login: this.Login,
                            Email: this.Email,
                            Password: this.Password,
                    })
                });
                if(response.ok === true){
                    console.log("Заебись");
                }
                else{
                    console.log("Хуево");
                }
            }
            else{
                this.clearBox("errors");
                const p = document.createElement("p");
                p.append("Пароли не совпадают");
                document.getElementById("errors").append(p);
                document.getElementById("errors").style.display = "block";
            }
        },
        addError(errors,elementid) {
            errors.forEach(error => {
                const p = document.createElement("p");
                p.append(error);
                document.getElementById(elementid).append(p);
            });
        },
        clearBox(elementID)
        {
            var div = document.getElementById(elementID);
            while(div.firstChild){
                div.removeChild(div.firstChild);
             }
        }
    }
}
</script>

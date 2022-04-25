<template>
    <b-container fluid class = "header">
        <b-row>
            <b-col cols="2" sm="2" md="3" lg="4" lx="4" >
                <b-navbar-brand href="#">
                    <router-link
                        :to="{name: 'home'}"
                    >                       
                    <a href="to"><img src="../../assets/logo.png" alt="Kitten" width="40" height="55"></a>
                    </router-link> 
                </b-navbar-brand>
            </b-col>
            <b-col cols="8" sm="8" md="6" lg="4" lx="4" > 
                fdsfs
            </b-col>
            <b-col cols="2" sm="2" md="3" lg="4" lx="4">
                <div id="buttonheader">
                    <b-button @click="$router.push('Registration')" type="button" id="buttonSing" >Sing up</b-button>
                    <b-button type="button" id="buttonSing" style="margin-left:5px">Sing in</b-button>
                </div>
            </b-col>
        </b-row>
    </b-container>
</template>
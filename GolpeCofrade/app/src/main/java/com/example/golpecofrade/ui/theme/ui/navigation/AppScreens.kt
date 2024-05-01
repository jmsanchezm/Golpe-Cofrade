package com.example.golpecofrade.ui.theme.ui.navigation

sealed class AppScreens (val route: String){

    object LoginScreen: AppScreens("login_screen")
    object  RegisterScreeen1:AppScreens("register_screen_1")
    object  RegisterScreeen2:AppScreens("register_screen_2")
    object  RegisterScreeen3:AppScreens("register_screen_3")
    object  VerificateAccount:AppScreens("verificate_account")

}
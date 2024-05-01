package com.example.golpecofrade.ui.theme.ui.navigation

import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.runtime.Composable
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable
import androidx.navigation.compose.rememberNavController
import com.example.golpecofrade.ui.theme.ui.screens.LoginScreen
import com.example.golpecofrade.ui.theme.ui.screens.RegisterScreen1
import com.example.golpecofrade.ui.theme.ui.screens.RegisterScreen2
import com.example.golpecofrade.ui.theme.ui.screens.RegisterScreen3
import com.example.golpecofrade.ui.theme.ui.screens.VerificateAccount
import com.example.golpecofrade.ui.theme.ui.viewmodels.LoginViewModel


@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun AppNavigation(){
    val navController =  rememberNavController()
    NavHost(navController = navController, startDestination= AppScreens.LoginScreen.route){
        composable(route = AppScreens.LoginScreen.route){
            LoginScreen(viewModel=LoginViewModel(),navController)
        }
        composable(route = AppScreens.RegisterScreeen1.route){
            RegisterScreen1(navController)
        }
        composable(route = AppScreens.RegisterScreeen2.route){
            RegisterScreen2(navController)
        }
        composable(route = AppScreens.RegisterScreeen3.route){
            RegisterScreen3(navController)
        }
        composable(route = AppScreens.VerificateAccount.route){
            VerificateAccount(navController)
        }
    }
}
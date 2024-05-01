package com.example.golpecofrade.ui.theme.ui.screens

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.width
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import com.example.golpecofrade.R
import com.example.golpecofrade.ui.theme.ui.navigation.AppScreens


/**
 * Función que establece el background de la pantalla
 */
@Composable
fun BackgroundImage(){
    Image(painter = painterResource(id = R.drawable.fondo),
        contentDescription = "background",
        contentScale = ContentScale.Crop,
        modifier = Modifier.fillMaxSize())
}

@Composable
fun BackVector(modifier: Modifier,navController: NavController){
    Box(
        modifier
            .clickable {
                navController.popBackStack()
            }
            .background(Color.Transparent)){
        Image(painter = painterResource(id = R.drawable.baseline_arrow_back_24),
            contentDescription = "Botón atrás")
    }
}

@Composable
fun LoginScreen(navController: NavController){
    Row (modifier = Modifier.clickable {
        navController.navigate(route = AppScreens.LoginScreen.route)
    }){
        Text(text = "¿Ya tienes cuenta?",
            fontSize = 12.sp,
            color = Color(0xFF3B0069)
        )
        Spacer(modifier = Modifier.width(3.dp))
        Text(text = "Iniciar sesión",
            fontSize = 12.sp,
            fontWeight = FontWeight.Black,
            color = Color(0xFF3B0069)
        )
    }
}

@Composable
fun NextButtonRegister(navController: NavController,route:String,mensaje:String) {
    Button(onClick = {
        navController.navigate(route = route)
    },
        modifier = Modifier.height(40.dp),
        colors = ButtonDefaults.buttonColors(
            containerColor = Color(0xFF3B0069),
            disabledContainerColor = Color(0xFF887299),
            contentColor = Color.White,
            disabledContentColor = Color.White
        )
    ) {
        Text(text = mensaje)
    }
}

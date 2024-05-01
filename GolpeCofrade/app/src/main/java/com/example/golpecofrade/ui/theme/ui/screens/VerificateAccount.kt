package com.example.golpecofrade.ui.theme.ui.screens

import androidx.compose.foundation.Image
import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.Spacer
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.height
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.layout.width
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.Button
import androidx.compose.material3.ButtonDefaults
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController
import androidx.navigation.NavHostController
import com.example.golpecofrade.R
import com.example.golpecofrade.ui.theme.ui.navigation.AppScreens

@ExperimentalMaterial3Api
@Composable
fun VerificateAccount(navController: NavHostController) {
    Box(
        Modifier
            .fillMaxSize()) {
        Register(Modifier.align(Alignment.Center),navController)
    }

}

@ExperimentalMaterial3Api
@Composable
private fun Register(modifier: Modifier,navController:NavController) {
    BackgroundImage()
    Row (modifier = Modifier.padding(30.dp)){
        BackVector(modifier, navController)
    }
    Column (modifier.padding(20.dp), horizontalAlignment = Alignment.CenterHorizontally){
        Spacer(modifier = Modifier.padding(40.dp))
        TitleName()
        Spacer(modifier = Modifier.padding(15.dp))
        CodeVerification()
        Spacer(modifier = Modifier.padding(120.dp))
        NextButtonRegister(navController,route = AppScreens.LoginScreen.route, mensaje = "Verificar cuenta")
        Spacer(modifier = Modifier.padding(25.dp))
    }
}

@Composable
private fun TitleName(){
    Spacer(modifier = Modifier.height(12.dp))
    Text(text = "Golpe Cofrade",
        style = TextStyle(
            fontSize = 40.sp,
            color = Color(0xFF3B0069),
            fontWeight = FontWeight.Black)
    )
    Spacer(modifier = Modifier.height(30.dp))
    Text(text = "Verificar cuenta",
        style = TextStyle(
            color = Color(0xFF3B0069),
            fontSize = 15.sp)
    )
}


@ExperimentalMaterial3Api
@Composable
private fun CodeVerification(){

    Column(modifier = Modifier) {

        Text(text = "Introduzca el código de verificación que le hemos enviado a su dirección de correo " +
                "electrónico. Por favor, si no ha recibido nada consulte la bandeja de spam.",
            fontSize = 12.sp,
            color = Color(0xFF3B0069))

        Spacer(modifier = Modifier.padding(15.dp))

        Row (modifier = Modifier){
            Spacer(modifier = Modifier.width(7.dp))
            Text(text = "Código de verificación",
                fontSize = 15.sp,
                color = Color(0xFF3B0069)
            )
        }

        Spacer(modifier = Modifier.padding(5.dp))

        TextField(value = "", onValueChange = {},
            Modifier.fillMaxWidth(),
            placeholder = {
                Text(text = "XXX-XXX" ,
                    color = Color(0xFF4E3463),
                    fontSize = 15.sp)
            },

            singleLine=true,
            maxLines = 1,
            colors = TextFieldDefaults.outlinedTextFieldColors(
                containerColor = Color(0x66DEDDDD),
                focusedBorderColor = Color.Transparent,
                unfocusedBorderColor = Color.Transparent),
            shape = RoundedCornerShape(10.dp),
            keyboardOptions = KeyboardOptions.Default.copy(keyboardType = KeyboardType.Phone))


    }
}


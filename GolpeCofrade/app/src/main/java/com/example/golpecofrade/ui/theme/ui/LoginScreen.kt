
package com.example.golpecofrade.ui.theme.ui

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
import androidx.compose.ui.text.font.FontFamily
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.Font
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.tooling.preview.Preview
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.golpecofrade.R

@ExperimentalMaterial3Api
@Preview (showBackground = true, showSystemUi = true)
@Composable
fun LoginScreen(){
    Box(
        Modifier
            .fillMaxSize()) {
        Login(Modifier.align(Alignment.Center))
    }

}
@ExperimentalMaterial3Api
@Composable
fun Login(modifier: Modifier){
    BackgroundImage()
    Column (modifier.padding(20.dp), horizontalAlignment = Alignment.CenterHorizontally){
        Spacer(modifier = Modifier.padding(50.dp))
        TitleName()
        Spacer(modifier = Modifier.padding(20.dp))
        UsernameField()
        Spacer(modifier = Modifier.padding(6.dp))
        PasswordField()
        Spacer(modifier = Modifier.padding(9.dp))
        ForgotPassword()
        Spacer(modifier = Modifier.padding(45.dp))
        LoginButton()
        Spacer(modifier = Modifier.padding(30.dp))
        RegisterUser()

    }

}

@Composable
fun BackgroundImage(){
    Image(painter = painterResource(id = R.drawable.fondo),
        contentDescription = "background",
        contentScale = ContentScale.Crop,
        modifier = Modifier.fillMaxSize())
}

@Composable
fun TitleName(){
    Spacer(modifier = Modifier.height(12.dp))
    Text(text = "Bienvenido a ",
        style = TextStyle(
            color = Color(0xFF3B0069),
            fontSize = 20.sp)
    )
    Text(text = "Golpe Cofrade",
        style = TextStyle(
            fontSize = 50.sp,
            color = Color(0xFF3B0069),
            fontWeight = FontWeight.Black)
    )
    Spacer(modifier = Modifier.height(30.dp))
    Text(text = "Iniciar sesión",
        style = TextStyle(
            color = Color(0xFF3B0069),
            fontSize = 15.sp)
    )
}

@ExperimentalMaterial3Api
@Composable
fun UsernameField(){
    Column(modifier = Modifier) {
        Row (modifier = Modifier){
            Spacer(modifier = Modifier.width(7.dp))
            Text(text = "Usuario",
                fontSize = 15.sp,
                color = Color(0xFF3B0069))
        }

        Spacer(modifier = Modifier.padding(5.dp))
        TextField(value = "", onValueChange = {},
            Modifier.fillMaxWidth(),
            placeholder = {Text(text = "Introduzca su nombre de usuario" ,
                color = Color(0xFF4E3463),
                fontSize = 15.sp)},
            singleLine=true,
            maxLines = 1,
            colors = TextFieldDefaults.outlinedTextFieldColors(
                containerColor = Color(0x66DEDDDD),
                focusedBorderColor = Color.Transparent,
                unfocusedBorderColor = Color.Transparent),
            shape = RoundedCornerShape(10.dp)
        )
    }


}
@ExperimentalMaterial3Api
@Composable
fun PasswordField(){

    Column {
        Row (modifier = Modifier){
            Spacer(modifier = Modifier.width(7.dp))
            Text(text = "Contraseña",
                fontSize = 15.sp,
                color = Color(0xFF3B0069))
        }
        Spacer(modifier = Modifier.padding(5.dp))
        TextField(value = "", onValueChange = {},
            Modifier.fillMaxWidth(),
            placeholder = {Text(text = "Introduzca su contraseña" ,
                fontSize = 15.sp,
                color = Color(0xFF4E3463))},
            singleLine=true,
            maxLines = 1,
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Password),
            colors = TextFieldDefaults.outlinedTextFieldColors(
                containerColor = Color(0x66DEDDDD),
                focusedBorderColor = Color.Transparent,
                unfocusedBorderColor = Color.Transparent),
            shape = RoundedCornerShape(10.dp)
        )
    }


}

@Composable
fun ForgotPassword(){
    Text(text = "¿Ha olvidado la contraseña?",
        modifier = Modifier.clickable {  },
        fontSize = 12.sp,
        fontWeight = FontWeight.Black,
        color = Color(0xFF3B0069)
    )
}

@Composable
fun LoginButton(){
    Button(onClick = { },
        modifier = Modifier.height(40.dp),
        colors = ButtonDefaults.buttonColors(
            containerColor = Color(0xFF3B0069),
            disabledContainerColor = Color(0xFF887299),
            contentColor = Color.White,
            disabledContentColor = Color.White
        )
    ) {
        Text(text = "Iniciar sesión")
    }
}

@Composable
fun RegisterUser(){
    Row (modifier = Modifier.clickable {  }){
        Text(text = "¿No tienes cuenta?",
            modifier = Modifier.clickable {  },
            fontSize = 12.sp,
            color = Color(0xFF3B0069)
        )
        Spacer(modifier = Modifier.width(3.dp))
        Text(text = "Regístrate",
            fontSize = 12.sp,
            fontWeight = FontWeight.Black,
            color = Color(0xFF3B0069))
    }
}



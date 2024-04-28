
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
import androidx.compose.material3.CircularProgressIndicator
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.material3.TextFieldDefaults
import androidx.compose.runtime.Composable
import androidx.compose.runtime.getValue
import androidx.compose.runtime.livedata.observeAsState
import androidx.compose.runtime.rememberCoroutineScope
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import androidx.compose.ui.text.TextStyle
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import com.example.golpecofrade.R
import com.example.golpecofrade.ui.theme.ui.viewmodels.LoginViewModel
import kotlinx.coroutines.launch

@ExperimentalMaterial3Api
@Composable
fun LoginScreen(viewModel: LoginViewModel){
    Box(
        Modifier
            .fillMaxSize()) {
        Login(Modifier.align(Alignment.Center), viewModel)
    }

}
@ExperimentalMaterial3Api
@Composable
private fun Login(modifier: Modifier,viewModel:LoginViewModel){

    val username : String by viewModel.username.observeAsState(initial = "")
    val password : String by viewModel.password.observeAsState(initial = "")
    val buttonEnabled:Boolean by viewModel.buttonEnabled.observeAsState(initial = false)

    val isLoading: Boolean by viewModel.isloading.observeAsState(initial = false)

    val coroutineScope = rememberCoroutineScope()

    if(isLoading){
        Box( Modifier.fillMaxSize()) {
            CircularProgressIndicator(Modifier.align(Alignment.Center))
        }
    }else{
        BackgroundImage()
        Column (modifier.padding(20.dp), horizontalAlignment = Alignment.CenterHorizontally){
            Spacer(modifier = Modifier.padding(40.dp))
            TitleName()
            Spacer(modifier = Modifier.padding(15.dp))
            UsernameField(username){viewModel.onLoginChanged(it,password)}
            Spacer(modifier = Modifier.padding(6.dp))
            PasswordField(password){viewModel.onLoginChanged(username,it)}
            Spacer(modifier = Modifier.padding(9.dp))
            ForgotPassword()
            Spacer(modifier = Modifier.padding(40.dp))
            LoginButton(buttonEnabled){
                coroutineScope.launch {
                    viewModel.onLoginSelected()
                }
            }
            Spacer(modifier = Modifier.padding(25.dp))
            RegisterUser()
        }
    }


}

@Composable
private fun BackgroundImage(){
    Image(painter = painterResource(id = R.drawable.fondo),
        contentDescription = "background",
        contentScale = ContentScale.Crop,
        modifier = Modifier.fillMaxSize())
}

@Composable
private fun TitleName(){
    Spacer(modifier = Modifier.height(12.dp))
    Text(text = "Bienvenido a ",
        style = TextStyle(
            color = Color(0xFF3B0069),
            fontSize = 20.sp)
    )
    Text(text = "Golpe Cofrade",
        style = TextStyle(
            fontSize = 40.sp,
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
private fun UsernameField(username: String, onTextFieldChanged:(String) -> Unit){

    Column(modifier = Modifier) {
        Row (modifier = Modifier){
            Spacer(modifier = Modifier.width(7.dp))
            Text(text = "Usuario",
                fontSize = 15.sp,
                color = Color(0xFF3B0069))
        }

        Spacer(modifier = Modifier.padding(5.dp))
        TextField(value = username, onValueChange = {onTextFieldChanged(it)},
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
private fun PasswordField(password:String,onTextFieldChanged:(String) -> Unit){

    Column {
        Row (modifier = Modifier){
            Spacer(modifier = Modifier.width(7.dp))
            Text(text = "Contraseña",
                fontSize = 15.sp,
                color = Color(0xFF3B0069))
        }
        Spacer(modifier = Modifier.padding(5.dp))
        TextField(value = password, onValueChange = {onTextFieldChanged(it)},
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
private fun ForgotPassword(){
    Text(text = "¿Ha olvidado la contraseña?",
        modifier = Modifier.clickable {  },
        fontSize = 12.sp,
        fontWeight = FontWeight.Black,
        color = Color(0xFF3B0069)
    )
}

@Composable
private fun LoginButton(buttonEnabled: Boolean, onLoginSelected: () -> Unit) {
    Button(onClick = { onLoginSelected() },
        modifier = Modifier.height(40.dp),
        colors = ButtonDefaults.buttonColors(
            containerColor = Color(0xFF3B0069),
            disabledContainerColor = Color(0xFF887299),
            contentColor = Color.White,
            disabledContentColor = Color.White
        ), enabled = buttonEnabled
    ) {
        Text(text = "Iniciar sesión")
    }
}

@Composable
private fun RegisterUser(){
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



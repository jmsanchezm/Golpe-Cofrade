
package com.example.golpecofrade.ui.theme.ui.screens


import androidx.compose.foundation.Image
import androidx.compose.foundation.layout.Box
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.runtime.Composable
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.layout.ContentScale
import androidx.compose.ui.res.painterResource
import com.example.golpecofrade.R
import com.example.golpecofrade.ui.theme.ui.viewmodels.RegisterViewModel

@ExperimentalMaterial3Api
@Composable
fun RegisterScreen(viewModel: RegisterViewModel){
    Box(
        Modifier
            .fillMaxSize()) {
        Register(Modifier.align(Alignment.Center), viewModel)
    }

}
@ExperimentalMaterial3Api
@Composable
fun Register(modifier: Modifier,viewModel:RegisterViewModel) {
    BackgroundImage()
    //Column(modifier)
}

@Composable
private fun BackgroundImage(){
    Image(painter = painterResource(id = R.drawable.fondo),
        contentDescription = "background",
        contentScale = ContentScale.Crop,
        modifier = Modifier.fillMaxSize())
}




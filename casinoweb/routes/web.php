<?php

use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('home');
});

//Route::post('/sendMessage', 'HomeController@sendMessage');
//Route::get('/sendMessage', [App\Http\Controllers\HomeController::class, 'index']);
Route::post('/sendmessage/', [App\Http\Controllers\HomeController::class, 'sendMessage'])->name('sendMessage');

Auth::routes();

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');
Route::get('/trades', [App\Http\Controllers\TradeController::class, 'index'])->name('trades');

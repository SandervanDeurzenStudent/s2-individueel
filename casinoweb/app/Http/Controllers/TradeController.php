<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class tradeController extends Controller
{
    public function index()
    {
        //data ophalen uit database
        $alldata = DB::table('messages')->get();
        $leaderboardData = DB::table('users')->orderByDesc('user_credits')->get();
        $b = DB::table('users')->orderByDesc('user_credits')->get();


        return view('trades.trades', [ 'alldata' => $alldata, 'leaderboardData' => $leaderboardData, 'leaderboardcount' => $b]);
    }
}

package com.example.myapp;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.util.Log;
import android.widget.ImageView;

import com.bumptech.glide.Glide;
import com.bumptech.glide.request.RequestOptions;
import com.example.myapp.application.HomeApplication;
import com.example.myapp.category.CategoriesAdapter;
import com.example.myapp.dto.category.CategoryItemDTO;
import com.example.myapp.services.ApplicationNetwork;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends BaseActivity {

    RecyclerView rcCategories;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // ImageView imageView = findViewById(R.id.imageView);
//        String url = "https://theadultman.com/wp-content/w3-webp/uploads/2021/06/High-value-woman_-Attractive-brunette-girl-in-yellow-top-smiling-.jpgw3.webp";
        //String url = "http://10.0.2.2:5096/images/2.webp";
//        String url = "https://vpd111.itstep.click/images/2.webp";
//
//        Glide.with(HomeApplication.getAppContext())
//                .load(url)
//                .apply(new RequestOptions().override(600))
//                .into(imageView);
        rcCategories = findViewById(R.id.rcCategories);
        rcCategories.setHasFixedSize(true);
        rcCategories.setLayoutManager(new GridLayoutManager(this, 1, RecyclerView.VERTICAL, false));


        ApplicationNetwork
                .getInstance()
                .getCategoriesApi()
                .list()
                .enqueue(new Callback<List<CategoryItemDTO>>() {
                    @Override
                    public void onResponse(Call<List<CategoryItemDTO>> call, Response<List<CategoryItemDTO>> response) {
                        if(response.isSuccessful()) {
                            List<CategoryItemDTO> items = response.body();
                            CategoriesAdapter ca = new CategoriesAdapter(items);
                            rcCategories.setAdapter(ca);
                            //int count = items.size();
                            //Log.d("---count---", String.valueOf(count));
                        }
                    }

                    @Override
                    public void onFailure(Call<List<CategoryItemDTO>> call, Throwable throwable) {
                        Log.e("--problem--", "error server");
                    }
                });

    }
}
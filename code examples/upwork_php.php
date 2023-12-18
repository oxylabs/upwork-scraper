<?php

$params = [
    'source' => 'universal',
    'url' => 'https://www.upwork.com/hire/landing/?utm_campaign=sembrand_google_intl_marketplace_core&utm_medium=paidsearch&utm_content=150606034558&utm_term=upwork&campaignid=20227594544&matchtype=e&device=c&partnerid=cj0kcqiayewrbhddarisagp1mwsp9zzkgwn_rdxwtubn7hqlmxlog0gmb0tscajaqy6fxziirl2vbyuaak0mealw_wcb&utm_source=google&cq_cmp=20227594544&cq_plac&cq_net=g&ad_id=660518288337&gad_source=1'];

$ch = curl_init();

curl_setopt($ch, CURLOPT_URL, "https://realtime.oxylabs.io/v1/queries");
curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
curl_setopt($ch, CURLOPT_POSTFIELDS, json_encode($params));
curl_setopt($ch, CURLOPT_POST, 1);
curl_setopt($ch, CURLOPT_USERPWD, "user" . ":" . "pass1");

$headers = array();
$headers[] = "Content-Type: application/json";
curl_setopt($ch, CURLOPT_HTTPHEADER, $headers);

$result = curl_exec($ch);
echo $result;

if (curl_errno($ch)) {
    echo 'Error:' . curl_error($ch);
}
curl_close ($ch);
?>
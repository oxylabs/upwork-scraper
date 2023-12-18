import fetch from 'node-fetch';

const username = 'YOUR_USERNAME';
const password = 'YOUR_PASSWORD';
const body = {
  'source': 'universal',
  'url': 'https://www.upwork.com/hire/landing/?utm_campaign=sembrand_google_intl_marketplace_core&utm_medium=paidsearch&utm_content=150606034558&utm_term=upwork&campaignid=20227594544&matchtype=e&device=c&partnerid=cj0kcqiayewrbhddarisagp1mwsp9zzkgwn_rdxwtubn7hqlmxlog0gmb0tscajaqy6fxziirl2vbyuaak0mealw_wcb&utm_source=google&cq_cmp=20227594544&cq_plac&cq_net=g&ad_id=660518288337&gad_source=1'};
  
const response = await fetch('https://realtime.oxylabs.io/v1/queries', {
  method: 'post',
  body: JSON.stringify(body),
  headers: {
    'Content-Type': 'application/json',
    'Authorization': 'Basic ' + Buffer.from(`${username}:${password}`).toString('base64'),
  }
});

console.log(await response.json());
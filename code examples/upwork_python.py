import requests
from pprint import pprint

# Structure payload.
payload = {
    'source': 'universal',
    'url': 'https://www.upwork.com/hire/landing/?utm_campaign=sembrand_google_intl_marketplace_core&utm_medium=paidsearch&utm_content=150606034558&utm_term=upwork&campaignid=20227594544&matchtype=e&device=c&partnerid=cj0kcqiayewrbhddarisagp1mwsp9zzkgwn_rdxwtubn7hqlmxlog0gmb0tscajaqy6fxziirl2vbyuaak0mealw_wcb&utm_source=google&cq_cmp=20227594544&cq_plac&cq_net=g&ad_id=660518288337&gad_source=1'
}

# Get response.
response = requests.request(
    'POST',
    'https://realtime.oxylabs.io/v1/queries',
    auth=('user', 'pass1'),
    json=payload,
)

# Instead of response with job status and results url, this will return the
# JSON response with the result.
pprint(response.json())
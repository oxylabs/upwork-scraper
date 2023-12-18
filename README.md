# Upwork Scraper API

[![Oxylabs promo code](https://user-images.githubusercontent.com/129506779/250792357-8289e25e-9c36-4dc0-a5e2-2706db797bb5.png)](https://oxylabs.go2cloud.org/aff_c?offer_id=7&aff_id=877&url_id=112)

Oxylabs’ [Upwork Scraper](https://oxylabs.io/products/scraper-api/web/upwork?utm_source=github&utm_medium=repositories&utm_campaign=product) is a data gathering solution allowing you to extract real-time information from an Upwork website effortlessly. This brief guide explains how an Upwork Scraper works and provides code examples to understand better how you can use it hassle-free.

### How it works

You can get Upwork results by providing your own URLs to our service. We can return the HTML for any Upwork page you like.

#### Python code example

The example below illustrates how you can get HTML of Upwork page.

```python
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
```
Find code examples for other programming languages [**here**](https://github.com/oxylabs/upwork-scraper/tree/main/code%20examples)

#### Output Example
```json
{
  "results": [
    {
      "content": "<!doctype html>\n<html data-n-head-ssr lang=\"en-us\" theme=\"air-3-0\" data-n-head=\"%7B%22lang%22:%7B%22 ... </html>",
      "created_at": "2023-12-18 10:40:20",
      "updated_at": "2023-12-18 10:40:22",
      "page": 1,
      "url": "https://www.upwork.com/hire/landing/?utm_campaign=sembrand_google_intl_marketplace_core&utm_medium=paidsearch&utm_content=150606034558&utm_term=upwork&campaignid=20227594544&matchtype=e&device=c&partnerid=cj0kcqiayewrbhddarisagp1mwsp9zzkgwn_rdxwtubn7hqlmxlog0gmb0tscajaqy6fxziirl2vbyuaak0mealw_wcb&utm_source=google&cq_cmp=20227594544&cq_plac&cq_net=g&ad_id=660518288337&gad_source=1",
      "job_id": "7142463589461265409",
      "status_code": 200
    }
  ]
}
```
With our Upwork Scraper, you can conveniently pull public data from any Upwork webpage. Gather the required freelancing information, such as work rates, client reviews, or job descriptions, to understand the freelancing landscape and stay at the top of your field. If you have any queries, our support team is at your service through live chat or you can email us at hello@oxylabs.io.